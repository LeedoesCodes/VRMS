using System;
using System.Collections.Generic;
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

            HookEvents();
            LoadContacts();
            ResetForm();
        }

        #region LOAD

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
                        .Select(p => new PhoneNumber { Number = p })
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

        #endregion

        #region EVENTS

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
            dgvPhoneNumbers.CellClick += PhoneGridClick;
        }

        #endregion

        #region CONTACT CRUD

        private void SaveContact(object? sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            int newId = _service.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.Text
            );

            foreach (var p in ReadPhones())
                _service.AddEmergencyContactPhoneNumber(newId, p.Normalized());

            LoadContacts();
            ResetForm();
        }

        private void UpdateContact(object? sender, EventArgs e)
        {
            if (_current == null || !ValidateForm()) return;

            // UI-only workaround: delete & recreate
            _service.DeleteEmergencyContact(_current.Id);

            int newId = _service.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.Text
            );

            foreach (var p in ReadPhones())
                _service.AddEmergencyContactPhoneNumber(newId, p.Normalized());

            LoadContacts();
            ResetForm();
        }

        private void DeleteContact(object? sender, EventArgs e)
        {
            if (_current == null) return;

            _service.DeleteEmergencyContact(_current.Id);
            LoadContacts();
            ResetForm();
        }

        #endregion

        #region UI HELPERS

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNotes.Clear();

            cmbRelationship.SelectedIndex = 0;
            dgvPhoneNumbers.Rows.Clear();

            _current = null;

            btnSaveContact.Enabled = true;
            btnUpdateContact.Enabled = false;
            btnDeleteContact.Enabled = false;
        }

        private void SelectContact(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvContacts.Rows[e.RowIndex].Cells[0].Value);
            _current = _contacts.First(c => c.Id == id);

            txtFirstName.Text = _current.FirstName;
            txtLastName.Text = _current.LastName;
            cmbRelationship.Text = _current.Relationship;

            dgvPhoneNumbers.Rows.Clear();
            foreach (var p in _current.Phones)
                dgvPhoneNumbers.Rows.Add(null, p.Type, p.Number, p.IsPrimary);

            btnSaveContact.Enabled = false;
            btnUpdateContact.Enabled = true;
            btnDeleteContact.Enabled = true;
        }

        private void AddPhoneRow()
        {
            dgvPhoneNumbers.Rows.Add(null, "Mobile", "", false);
        }

        private void PhoneGridClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhoneNumbers.Columns["colRemovePhone"].Index
                && e.RowIndex >= 0)
            {
                dgvPhoneNumbers.Rows.RemoveAt(e.RowIndex);
            }
        }

        #endregion

        #region VALIDATION

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) return false;
            if (cmbRelationship.SelectedItem == null) return false;
            if (dgvPhoneNumbers.Rows.Count == 0) return false;

            return true;
        }

        private List<PhoneNumber> ReadPhones()
        {
            var list = new List<PhoneNumber>();

            foreach (DataGridViewRow row in dgvPhoneNumbers.Rows)
            {
                if (row.IsNewRow) continue;

                list.Add(new PhoneNumber
                {
                    Type = row.Cells["colPhoneType"].Value?.ToString() ?? "Mobile",
                    Number = row.Cells["colPhoneNumber"].Value?.ToString() ?? "",
                    IsPrimary = Convert.ToBoolean(row.Cells["colPrimary"].Value ?? false)
                });
            }

            return list;
        }

        #endregion
    }
}
