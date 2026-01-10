using System;
using System.Windows.Forms;
using VRMS.Models.Fleet;
using VRMS.Enums;
using VRMS.Services.Fleet;

namespace VRMS.Forms
{
    public partial class EditVehicleForm : Form
    {
        private readonly int _vehicleId;
        private readonly VehicleService _vehicleService;

        private Vehicle _vehicle = null!;
        private bool _isLoaded = false; // IMPORTANT FLAG

        // =========================
        // CONSTRUCTOR
        // =========================
        public EditVehicleForm(int vehicleId, VehicleService vehicleService)
        {
            InitializeComponent();

            _vehicleId = vehicleId;
            _vehicleService = vehicleService;

            btnSave.Enabled = false;

            Load += EditVehicleForm_Load;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
        }

        // =========================
        // LOAD VEHICLE
        // =========================
        private void EditVehicleForm_Load(object sender, EventArgs e)
        {
            try
            {
                _vehicle = _vehicleService.GetVehicleFull(_vehicleId);

                PopulateForm();
                HookValidationEvents();

                _isLoaded = true;
                ValidateFormState(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error Loading Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Close();
            }
        }

        // =========================
        // POPULATE FORM
        // =========================
        private void PopulateForm()
        {
            // Identity (read-only)
            txtMake.Text = _vehicle.Make;
            txtModel.Text = _vehicle.Model;
            numYear.Value = _vehicle.Year;
            txtPlate.Text = _vehicle.LicensePlate;
            txtVIN.Text = _vehicle.VIN;

            // Editable
            txtColor.Text = _vehicle.Color;
            numMileage.Value = _vehicle.Odometer;
            numSeats.Value = _vehicle.SeatingCapacity;

            // Enums
            cbTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));
            cbFuel.DataSource = Enum.GetValues(typeof(FuelType));
            cbStatus.DataSource = Enum.GetValues(typeof(VehicleStatus));

            cbTransmission.SelectedItem = _vehicle.Transmission;
            cbFuel.SelectedItem = _vehicle.FuelType;
            cbStatus.SelectedItem = _vehicle.Status;

            // Lock immutable fields
            txtMake.ReadOnly = true;
            txtModel.ReadOnly = true;
            numYear.Enabled = false;
            txtPlate.ReadOnly = true;
            txtVIN.ReadOnly = true;

            cbTransmission.Enabled = false;
            cbFuel.Enabled = false;
            numSeats.Enabled = false;
        }

        // =========================
        // EVENT HOOKING
        // =========================
        private void HookValidationEvents()
        {
            txtColor.TextChanged += ValidateFormState;
            numMileage.ValueChanged += ValidateFormState;
            cbStatus.SelectedIndexChanged += ValidateFormState;
        }

        // =========================
        // SAVE CHANGES
        // =========================
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                ValidateForm();

                _vehicleService.UpdateVehicle(
                    vehicleId: _vehicleId,
                    color: txtColor.Text.Trim(),
                    newOdometer: (int)numMileage.Value,
                    fuelEfficiency: _vehicle.FuelEfficiency,
                    cargoCapacity: _vehicle.CargoCapacity,
                    categoryId: _vehicle.VehicleCategoryId
                );

                var newStatus = (VehicleStatus)cbStatus.SelectedItem!;
                if (newStatus != _vehicle.Status)
                {
                    _vehicleService.UpdateVehicleStatus(
                        _vehicleId,
                        newStatus
                    );
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // VALIDATION (STRICT)
        // =========================
        private void ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text))
                throw new InvalidOperationException("Color is required.");

            if (numMileage.Value < _vehicle.Odometer)
                throw new InvalidOperationException(
                    "Odometer value cannot be less than the current reading."
                );
        }

        // =========================
        // VALIDATION (STATE)
        // =========================
        private void ValidateFormState(object? sender, EventArgs e)
        {
            if (!_isLoaded || _vehicle == null)
                return;

            bool hasChanges =
                txtColor.Text.Trim() != _vehicle.Color ||
                numMileage.Value != _vehicle.Odometer ||
                (VehicleStatus)cbStatus.SelectedItem! != _vehicle.Status;

            btnSave.Enabled = hasChanges;
        }
    }
}
