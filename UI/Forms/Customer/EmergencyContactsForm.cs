using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VRMS.Services.Customer;

namespace VRMS.UI.Forms.Customer
{
    public partial class EmergencyContactsForm : Form
    {
        #region UI MODELS

        private class PhoneNumber
        {
            public string Type { get; set; } = "Mobile";
            public string Number { get; set; } = "";
            public bool IsPrimary { get; set; }

            public string Normalized()
                => new string(Number.Where(char.IsDigit).ToArray());
        }

        private class EmergencyContact
        {
            public int Id;
            public string FirstName = "";
            public string LastName = "";
            public string Relationship = "";
            public List<PhoneNumber> Phones = new();

            public string FullName => $"{FirstName} {LastName}";
        }

        #endregion

        private readonly EmergencyContactService _service;
        private readonly List<EmergencyContact> _contacts = new();
        private EmergencyContact? _current;

        public int CustomerId { get; }
        public string CustomerName { get; }

        public EmergencyContactsForm(int customerId, string customerName)
        {
            InitializeComponent();

            CustomerId = customerId;
            CustomerName = customerName;
            _service = new EmergencyContactService();

            lblCustomerName.Text = customerName;

            InitializeDefaults();
            HookEvents();
            LoadContacts();
            ResetForm();
        }

        // =====================================================
        // INIT & LOAD
        // =====================================================

        private void InitializeDefaults()
        {
            if (cmbRelationship.Items.Count == 0)
            {
                cmbRelationship.Items.AddRange(new object[]
                {
                    "Parent", "Sibling", "Spouse", "Partner",
                    "Friend", "Relative", "Guardian", "Other"
                });
            }
            cmbRelationship.SelectedIndex = 0;
        }

        private void LoadContacts()
        {
            _contacts.Clear();
            dgvContacts.Rows.Clear();

            var serviceContacts = _service.GetEmergencyContactsByCustomerId(CustomerId);

            foreach (var c in serviceContacts)
            {
                var contact = new EmergencyContact
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Relationship = c.Relationship,
                    Phones = _service
                        .GetEmergencyContactPhoneNumbers(c.Id)
                        .Select(p => new PhoneNumber
                        {
                            Type = "Mobile",
                            Number = p.PhoneNumber,
                            IsPrimary = p.IsPrimary
                        })
                        .ToList()
                };

                _contacts.Add(contact);

                dgvContacts.Rows.Add(
                    contact.Id,
                    contact.FullName,
                    contact.Relationship,
                    contact.Phones.Count
                );
            }

            lblContactCount.Text = $"{_contacts.Count} emergency contact(s)";
        }

        // =====================================================
        // EVENT HOOKS (Fixes CS0103 Errors)
        // =====================================================

        private void HookEvents()
        {
            btnAddNew.Click += (_, _) => ResetForm();
            btnClear.Click += (_, _) => ResetForm();
            btnClose.Click += (_, _) => Close();

            btnSaveContact.Click += SaveContact;
            btnUpdateContact.Click += UpdateContact;
            btnDeleteContact.Click += DeleteContact;

            btnAddPhone.Click += (_, _) => AddPhoneRow();

            dgvContacts.CellClick += SelectContact;

            // Note: dgvPhoneNumbers events are already wired in InitializeComponent()
            // to the methods defined below.
        }

        // These methods fix the "Does not exist in current context" errors
        private void DgvPhoneNumbers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Handle the "Remove" button click
            if (dgvPhoneNumbers.Columns[e.ColumnIndex].Name == "colRemovePhone")
            {
                bool wasPrimary = Convert.ToBoolean(dgvPhoneNumbers.Rows[e.RowIndex].Cells["colPrimary"].Value ?? false);

                dgvPhoneNumbers.Rows.RemoveAt(e.RowIndex);

                if (wasPrimary && dgvPhoneNumbers.Rows.Count > 0)
                {
                    dgvPhoneNumbers.Rows[0].Cells["colPrimary"].Value = true;
                }
            }
        }

        private void DgvPhoneNumbers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Handle Primary Checkbox Mutex (only one can be true)
            if (dgvPhoneNumbers.Columns[e.ColumnIndex].Name == "colPrimary")
            {
                bool isChecked = Convert.ToBoolean(dgvPhoneNumbers.Rows[e.RowIndex].Cells["colPrimary"].Value);

                if (isChecked)
                {
                    foreach (DataGridViewRow row in dgvPhoneNumbers.Rows)
                    {
                        if (row.Index != e.RowIndex && !row.IsNewRow)
                        {
                            row.Cells["colPrimary"].Value = false;
                        }
                    }
                }
            }
        }

        private void DgvPhoneNumbers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Forces the grid to commit the checkbox change immediately so CellValueChanged fires
            if (dgvPhoneNumbers.IsCurrentCellDirty)
            {
                dgvPhoneNumbers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // =====================================================
        // CONTACT CRUD
        // =====================================================

        private void SaveContact(object? sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            int newId = _service.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.Text
            );

            SavePhones(newId);
            LoadContacts();
            ResetForm();
        }

        private void UpdateContact(object? sender, EventArgs e)
        {
            if (_current == null || !ValidateForm()) return;

            _service.DeleteEmergencyContact(_current.Id);

            int newId = _service.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.Text
            );

            SavePhones(newId);
            LoadContacts();
            ResetForm();
        }

        private void SavePhones(int contactId)
        {
            foreach (var p in ReadPhones())
            {
                if (!string.IsNullOrWhiteSpace(p.Normalized()))
                    _service.AddEmergencyContactPhoneNumber(contactId, p.Normalized(), p.IsPrimary);
            }
        }

        private void DeleteContact(object? sender, EventArgs e)
        {
            if (_current == null) return;

            if (MessageBox.Show("Delete this contact?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _service.DeleteEmergencyContact(_current.Id);
                LoadContacts();
                ResetForm();
            }
        }

        // =====================================================
        // UI HELPERS & VALIDATION
        // =====================================================

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
           
            cmbRelationship.SelectedIndex = 0;
            dgvPhoneNumbers.Rows.Clear();
            _current = null;

            btnSaveContact.Enabled = true;
            btnUpdateContact.Enabled = false;
            btnDeleteContact.Enabled = false;
        }

        private void SelectContact(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContacts.Rows.Count) return;

            if (int.TryParse(dgvContacts.Rows[e.RowIndex].Cells[0].Value?.ToString(), out int id))
            {
                _current = _contacts.FirstOrDefault(c => c.Id == id);
                if (_current == null) return;

                txtFirstName.Text = _current.FirstName;
                txtLastName.Text = _current.LastName;
                cmbRelationship.Text = _current.Relationship;

                dgvPhoneNumbers.Rows.Clear();
                foreach (var p in _current.Phones)
                {
                    dgvPhoneNumbers.Rows.Add(null, p.Type, p.Number, p.IsPrimary);
                }

                btnSaveContact.Enabled = false;
                btnUpdateContact.Enabled = true;
                btnDeleteContact.Enabled = true;
            }
        }

        private void AddPhoneRow()
        {
            bool hasPrimary = ReadPhones().Any(p => p.IsPrimary);
            dgvPhoneNumbers.Rows.Add(null, "Mobile", "", !hasPrimary);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) { MessageBox.Show("First name required."); return false; }
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) { MessageBox.Show("Last name required."); return false; }

            var phones = ReadPhones();
            if (phones.Count == 0) { MessageBox.Show("At least one phone number is required."); return false; }
            if (!phones.Any(p => p.IsPrimary)) { MessageBox.Show("Please select one primary phone number."); return false; }

            return true;
        }

        private List<PhoneNumber> ReadPhones()
        {
            var list = new List<PhoneNumber>();
            foreach (DataGridViewRow row in dgvPhoneNumbers.Rows)
            {
                if (row.IsNewRow) continue;
                var number = row.Cells["colPhoneNumber"].Value?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(number)) continue;

                list.Add(new PhoneNumber
                {
                    Type = row.Cells["colPhoneType"].Value?.ToString() ?? "Mobile",
                    Number = number,
                    IsPrimary = Convert.ToBoolean(row.Cells["colPrimary"].Value ?? false)
                });
            }
            return list;
        }


    }
}