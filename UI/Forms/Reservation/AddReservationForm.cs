using System;
using System.Drawing;
using System.Windows.Forms;
using VRMS.Forms.Payments;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.UI.Forms.Rentals;
using VRMS.Models.Customers;
using VRMS.Models.Fleet;

namespace VRMS.Forms
{
    public partial class AddReservationForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;

        private Customer _selectedCustomer;
        private Vehicle _selectedVehicle;

        public AddReservationForm(
            CustomerService customerService,
            VehicleService vehicleService)
        {
            InitializeComponent();

            _customerService = customerService;
            _vehicleService = vehicleService;

            // Designer already wires button clicks
            btnCancel.Click += (_, __) => Close();

            UpdateSaveButtonState();
        }

        // ----------------------------------
        // CUSTOMER
        // ----------------------------------
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            using var form = new SelectCustomerForm(_customerService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _selectedCustomer = form.SelectedCustomer;
                UpdateCustomerDisplay();
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            _selectedCustomer = null;
            UpdateCustomerDisplay();
        }

        private void UpdateCustomerDisplay()
        {
            if (_selectedCustomer != null)
            {
                lblSelectedCustomer.Text =
                    $"{_selectedCustomer.FirstName} {_selectedCustomer.LastName}";
                lblSelectedCustomer.ForeColor = Color.FromArgb(44, 62, 80);
                btnClearCustomer.Visible = true;
            }
            else
            {
                lblSelectedCustomer.Text = "Not selected...";
                lblSelectedCustomer.ForeColor = Color.Gray;
                btnClearCustomer.Visible = false;
            }

            UpdateSaveButtonState();
        }

        // ----------------------------------
        // VEHICLE
        // ----------------------------------
        private void btnSelectVehicle_Click(object sender, EventArgs e)
        {
            using var form = new SelectVehicleForm(_vehicleService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _selectedVehicle = form.SelectedVehicle;
                UpdateVehicleDisplay();
            }
        }

        private void btnClearVehicle_Click(object sender, EventArgs e)
        {
            _selectedVehicle = null;
            UpdateVehicleDisplay();
        }

        private void UpdateVehicleDisplay()
        {
            if (_selectedVehicle != null)
            {
                lblSelectedVehicle.Text =
                    $"{_selectedVehicle.Make} {_selectedVehicle.Model} ({_selectedVehicle.LicensePlate})";
                lblSelectedVehicle.ForeColor = Color.FromArgb(44, 62, 80);
                btnClearVehicle.Visible = true;
            }
            else
            {
                lblSelectedVehicle.Text = "Not selected...";
                lblSelectedVehicle.ForeColor = Color.Gray;
                btnClearVehicle.Visible = false;
            }

            UpdateSaveButtonState();
        }

        // ----------------------------------
        // SAVE
        // ----------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedCustomer == null)
                    throw new InvalidOperationException("Please select a customer.");

                if (_selectedVehicle == null)
                    throw new InvalidOperationException("Please select a vehicle.");

                // Example amount – replace with real calculation later
                decimal amount = 1500.00m;

                using var paymentForm =
                    new ReservationDownPaymentForm();
                // Optional future:
                // paymentForm.SetData(
                //     $"{_selectedCustomer.FirstName} {_selectedCustomer.LastName}",
                //     $"{_selectedVehicle.Make} {_selectedVehicle.Model}",
                //     amount);

                if (paymentForm.ShowDialog() != DialogResult.OK)
                    return;

                // TODO: ReservationService.CreateReservation(...)
                MessageBox.Show(
                    "Reservation successfully created.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cannot Proceed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ----------------------------------
        // HELPERS
        // ----------------------------------
        private void UpdateSaveButtonState()
        {
            btnSave.Enabled =
                _selectedCustomer != null &&
                _selectedVehicle != null;
        }
    }
}
