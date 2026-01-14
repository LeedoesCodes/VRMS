using VRMS.Models.Fleet;
using VRMS.Repositories.Billing;
using VRMS.Repositories.Rentals;
using VRMS.Services.Billing;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;
using VRMS.UI.ApplicationService;
using VRMS.UI.Forms.Payments;
using VRMS.UI.Forms.Select;

namespace VRMS.UI.Forms.Reservation
{
    public partial class AddReservationForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;
        private readonly ReservationService _reservationService;
        private readonly RateService _rateService;

        private Models.Customers.Customer _selectedCustomer;
        private Vehicle _selectedVehicle;

        public AddReservationForm()
        {
            InitializeComponent();

            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;
            _reservationService = ApplicationServices.ReservationService;
            _rateService = ApplicationServices.RateService;

            btnCancel.Click += (_, __) => Close();

            dtpStart.ValueChanged += (_, __) => UpdateTotalEstimate();
            dtpEnd.ValueChanged += (_, __) => UpdateTotalEstimate();

            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = dtpStart.Value.AddDays(1);

            dtpStart.ValueChanged += (_, __) =>
            {
                if (dtpEnd.Value <= dtpStart.Value)
                    dtpEnd.Value = dtpStart.Value.AddDays(1);

                dtpEnd.MinDate = dtpStart.Value.AddDays(1);
                UpdateTotalEstimate();
            };

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
            UpdateTotalEstimate();
        }

        // ----------------------------------
        // SAVE
        // ----------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null || _selectedVehicle == null)
                return;

            var start = dtpStart.Value.Date;
            var end = dtpEnd.Value.Date.AddDays(1).AddTicks(-1);

            try
            {
                _reservationService.CreateReservation(
                    _selectedCustomer.Id,
                    _selectedVehicle.Id,
                    start,
                    end
                );

                MessageBox.Show(
                    "Reservation saved successfully.\nStatus: Pending",
                    "Reservation Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cannot Save Reservation",
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

        private void UpdateTotalEstimate()
        {
            if (_selectedVehicle == null)
            {
                lblTotal.Text = "Total: ₱0.00";
                return;
            }

            var start = dtpStart.Value.Date;
            var end = dtpEnd.Value.Date.AddDays(1).AddTicks(-1); // treat end date as inclusive day-end if that's your UX

            try
            {
                // RateService expects pickup and return datetimes (use start at midnight and end at end-of-day)
                var amount = _rateService.CalculateRentalCost(
                    start,
                    end,
                    _selectedVehicle.VehicleCategoryId);

                lblTotal.Text = $"Total: ₱{amount:N2}";
            }
            catch (Exception)
            {
                // On invalid dates or missing rate config, just show zero
                lblTotal.Text = "Total: ₱0.00";
            }
        }

    }
}