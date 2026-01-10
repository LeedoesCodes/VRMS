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
        #region MODELS

        public class PhoneNumber
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public string Type { get; set; }
            public bool IsPrimary { get; set; }

            public string GetFormattedNumber()
                => new string(Number.Where(char.IsDigit).ToArray());
        }

        public class EmergencyContact
        {
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Relationship { get; set; }
            public string Notes { get; set; }
            public List<PhoneNumber> PhoneNumbers { get; set; } = new();

            public string FullName => $"{FirstName} {LastName}";

            public EmergencyContact Clone()
            {
                return new EmergencyContact
                {
                    Id = Id,
                    CustomerId = CustomerId,
                    FirstName = FirstName,
                    LastName = LastName,
                    Relationship = Relationship,
                    Notes = Notes,
                    PhoneNumbers = PhoneNumbers
                        .Select(p => new PhoneNumber
                        {
                            Id = p.Id,
                            Number = p.Number,
                            Type = p.Type,
                            IsPrimary = p.IsPrimary
                        }).ToList()
                };
            }
        }

        #endregion

        private readonly EmergencyContactService emergencyContactService;
        private readonly List<EmergencyContact> contacts = new();

        private EmergencyContact? currentContact;
        private bool isEditing;
        private bool hasUnsavedChanges;

        public int CustomerId { get; }
        public string CustomerName { get; }

        public EmergencyContactsForm(int customerId, string customerName)
        {
            InitializeComponent();

            CustomerId = customerId;
            CustomerName = customerName;

            emergencyContactService = new EmergencyContactService();

            lblCustomerName.Text = CustomerName;

            cmbRelationship.Items.AddRange(new[]
            {
                "Spouse", "Parent", "Child", "Sibling", "Friend", "Colleague", "Other"
            });
            cmbRelationship.SelectedIndex = 0;

            LoadContacts();
            HookEvents();
        }

        #region LOAD

        private void LoadContacts()
        {
            contacts.Clear();

            var serviceContacts =
                emergencyContactService.GetEmergencyContactsByCustomerId(CustomerId);

            foreach (var c in serviceContacts)
            {
                contacts.Add(new EmergencyContact
                {
                    Id = c.Id,
                    CustomerId = c.CustomerId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Relationship = c.Relationship,
                    PhoneNumbers = emergencyContactService
                        .GetEmergencyContactPhoneNumbers(c.Id)
                        .Select(p => new PhoneNumber { Number = p })
                        .ToList()
                });
            }

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvContacts.Rows.Clear();

            foreach (var c in contacts)
            {
                dgvContacts.Rows.Add(
                    c.Id,
                    c.FullName,
                    c.Relationship,
                    c.PhoneNumbers.Count
                );
            }
        }

        #endregion

        #region EVENTS

        private void HookEvents()
        {
            btnAddNew.Click += (_, _) => StartNew();
            btnSaveContact.Click += BtnSave_Click;
            btnUpdateContact.Click += BtnUpdate_Click;
            btnDeleteContact.Click += BtnDelete_Click;
            btnClear.Click += (_, _) => ClearForm();
            btnClose.Click += (_, _) => Close();

            txtFirstName.TextChanged += OnChanged;
            txtLastName.TextChanged += OnChanged;
            cmbRelationship.SelectedIndexChanged += OnChanged;

            dgvContacts.CellClick += DgvContacts_CellClick;
        }

        #endregion

        #region CRUD

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            int newId = emergencyContactService.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.SelectedItem.ToString()
            );

            foreach (var p in GetPhones())
                emergencyContactService.AddEmergencyContactPhoneNumber(
                    newId, p.GetFormattedNumber());

            LoadContacts();
            ClearForm();
        }

        /// <summary>
        /// 🔥 FIXED UPDATE WITHOUT SERVICE CHANGE
        /// </summary>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (currentContact == null || !ValidateForm())
                return;

            var phones = GetPhones();

            // 🔴 Delete old contact
            emergencyContactService.DeleteEmergencyContact(currentContact.Id);

            // 🟢 Recreate contact
            int newId = emergencyContactService.CreateEmergencyContact(
                CustomerId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cmbRelationship.SelectedItem.ToString()
            );

            // 🟢 Re-add phones
            foreach (var p in phones)
                emergencyContactService.AddEmergencyContactPhoneNumber(
                    newId, p.GetFormattedNumber());

            LoadContacts();
            ClearForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (currentContact == null) return;

            emergencyContactService.DeleteEmergencyContact(currentContact.Id);
            LoadContacts();
            ClearForm();
        }

        #endregion

        #region UI

        private void StartNew()
        {
            ClearForm();
            isEditing = false;
            currentContact = null;
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNotes.Clear();
            dgvPhoneNumbers.Rows.Clear();

            currentContact = null;
            hasUnsavedChanges = false;
        }

        private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvContacts.Rows[e.RowIndex].Cells[0].Value);
            currentContact = contacts.First(c => c.Id == id).Clone();

            txtFirstName.Text = currentContact.FirstName;
            txtLastName.Text = currentContact.LastName;
            cmbRelationship.SelectedItem = currentContact.Relationship;

            dgvPhoneNumbers.Rows.Clear();
            foreach (var p in currentContact.PhoneNumbers)
                dgvPhoneNumbers.Rows.Add(0, "Mobile", p.Number, p.IsPrimary);

            isEditing = true;
        }

        private void OnChanged(object? sender, EventArgs e)
        {
            hasUnsavedChanges = true;
        }

        #endregion

        #region HELPERS

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) return false;
            if (cmbRelationship.SelectedItem == null) return false;
            return dgvPhoneNumbers.Rows.Count > 0;
        }

        private List<PhoneNumber> GetPhones()
        {
            var list = new List<PhoneNumber>();

            foreach (DataGridViewRow r in dgvPhoneNumbers.Rows)
            {
                if (r.IsNewRow) continue;

                list.Add(new PhoneNumber
                {
                    Number = r.Cells["colPhoneNumber"].Value?.ToString() ?? ""
                });
            }

            return list;
        }

        #endregion
    }
}
