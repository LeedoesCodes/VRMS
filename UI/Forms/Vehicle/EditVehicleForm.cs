using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Fleet;
using VRMS.Services.Fleet;

namespace VRMS.Forms
{
    public partial class EditVehicleForm : Form
    {
        private readonly int _vehicleId;
        private readonly VehicleService _vehicleService;

        private Vehicle _vehicle = null!;
        private bool _isLoaded;

        // ORIGINAL VALUES (for change detection)
        private decimal _originalFuelEfficiency;
        private int _originalCargoCapacity;
        private HashSet<int> _originalFeatureIds = new();

        // =========================
        // SAVE BUTTON COLORS
        // =========================
        private readonly Color _saveEnabledColor =
            Color.FromArgb(46, 204, 113);
        private readonly Color _saveDisabledColor =
            Color.FromArgb(189, 195, 199);
        private readonly Color _saveDisabledTextColor =
            Color.FromArgb(120, 120, 120);

        private readonly Color _errorBackColor =
            Color.FromArgb(255, 235, 238);
        private readonly Color _normalBackColor =
            Color.White;

        // =========================
        // CONSTRUCTOR
        // =========================
        public EditVehicleForm(int vehicleId, VehicleService vehicleService)
        {
            InitializeComponent();

            _vehicleId = vehicleId;
            _vehicleService = vehicleService;

            HookEvents();
            Load += EditVehicleForm_Load;
        }

        // =========================
        // EVENT WIRING
        // =========================
        private void HookEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();

            txtColor.TextChanged += (_, __) => UpdateSaveButtonState();
            numMileage.ValueChanged += (_, __) => UpdateSaveButtonState();
            txtFuelEfficiency.TextChanged += (_, __) => UpdateSaveButtonState();
            numCargoCapacity.ValueChanged += (_, __) => UpdateSaveButtonState();
            cbStatus.SelectedIndexChanged += (_, __) => UpdateSaveButtonState();

            chkAC.CheckedChanged += (_, __) => UpdateSaveButtonState();
            chkGPS.CheckedChanged += (_, __) => UpdateSaveButtonState();
            chkBluetooth.CheckedChanged += (_, __) => UpdateSaveButtonState();
            chkChildSeat.CheckedChanged += (_, __) => UpdateSaveButtonState();
            chkInsuranceIncluded.CheckedChanged += (_, __) => UpdateSaveButtonState();
        }

        // =========================
        // LOAD VEHICLE
        // =========================
        private void EditVehicleForm_Load(object? sender, EventArgs e)
        {
            try
            {
                _vehicle = _vehicleService.GetVehicleFull(_vehicleId);

                ConfigureEnums();
                PopulateForm();
                LoadFeatures();

                LockImmutableFields();

                _isLoaded = true;
                UpdateSaveButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error Loading Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        // =========================
        // CONFIGURATION
        // =========================
        private void ConfigureEnums()
        {
            cbTransmission.DataSource =
                Enum.GetValues(typeof(TransmissionType));
            cbFuel.DataSource =
                Enum.GetValues(typeof(FuelType));
            cbStatus.DataSource =
                Enum.GetValues(typeof(VehicleStatus));
        }

        private void PopulateForm()
        {
            txtMake.Text = _vehicle.Make;
            txtModel.Text = _vehicle.Model;
            numYear.Value = _vehicle.Year;
            txtPlate.Text = _vehicle.LicensePlate;
            txtVIN.Text = _vehicle.VIN;

            txtColor.Text = _vehicle.Color;
            numMileage.Value = _vehicle.Odometer;
            numSeats.Value = _vehicle.SeatingCapacity;

            txtFuelEfficiency.Text = _vehicle.FuelEfficiency.ToString("0.##");
            numCargoCapacity.Value = _vehicle.CargoCapacity;

            cbTransmission.SelectedItem = _vehicle.Transmission;
            cbFuel.SelectedItem = _vehicle.FuelType;
            cbStatus.SelectedItem = _vehicle.Status;

            _originalFuelEfficiency = _vehicle.FuelEfficiency;
            _originalCargoCapacity = _vehicle.CargoCapacity;
        }

        private void LockImmutableFields()
        {
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
        // FEATURES
        // =========================
        private void LoadFeatures()
        {
            var features =
                _vehicleService.GetVehicleFeatures(_vehicleId);

            _originalFeatureIds =
                features.Select(f => f.Id).ToHashSet();

            chkAC.Checked =
                features.Any(f => f.Name == "Air Conditioning");
            chkGPS.Checked =
                features.Any(f => f.Name == "GPS Navigation");
            chkBluetooth.Checked =
                features.Any(f => f.Name == "Bluetooth Connectivity");
            chkChildSeat.Checked =
                features.Any(f => f.Name == "Child Seat Availability");
            chkInsuranceIncluded.Checked =
                features.Any(f => f.Name == "Insurance Coverage Included");
        }

        private HashSet<int> GetSelectedFeatureIds()
        {
            var all = _vehicleService.GetAllFeatures();
            var selected = new HashSet<int>();

            void Add(string name)
            {
                var f = all.FirstOrDefault(x => x.Name == name);
                if (f != null) selected.Add(f.Id);
            }

            if (chkAC.Checked) Add("Air Conditioning");
            if (chkGPS.Checked) Add("GPS Navigation");
            if (chkBluetooth.Checked) Add("Bluetooth Connectivity");
            if (chkChildSeat.Checked) Add("Child Seat Availability");
            if (chkInsuranceIncluded.Checked) Add("Insurance Coverage Included");

            return selected;
        }

        private bool FeaturesChanged()
        {
            return !_originalFeatureIds
                .SetEquals(GetSelectedFeatureIds());
        }

        // =========================
        // SAVE
        // =========================
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            ResetErrorStyles();

            var errors = ValidateFormDetailed();
            if (errors.Count > 0)
            {
                ShowValidationErrors(errors);
                return;
            }

            if (!HasChanges())
            {
                MessageBox.Show(
                    "No changes were made.\n\nNothing to save.",
                    "Nothing to Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                _vehicleService.UpdateVehicle(
                    vehicleId: _vehicleId,
                    color: txtColor.Text.Trim(),
                    newOdometer: (int)numMileage.Value,
                    fuelEfficiency:
                        decimal.Parse(txtFuelEfficiency.Text),
                    cargoCapacity:
                        (int)numCargoCapacity.Value,
                    categoryId: _vehicle.VehicleCategoryId
                );

                var newStatus =
                    (VehicleStatus)cbStatus.SelectedItem!;

                if (newStatus != _vehicle.Status)
                    _vehicleService.UpdateVehicleStatus(
                        _vehicleId, newStatus);

                var newFeatures = GetSelectedFeatureIds();

                foreach (var id in _originalFeatureIds.Except(newFeatures))
                    _vehicleService.RemoveFeatureFromVehicle(
                        _vehicleId, id);

                foreach (var id in newFeatures.Except(_originalFeatureIds))
                    _vehicleService.AddFeatureToVehicle(
                        _vehicleId, id);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // VALIDATION
        // =========================
        private List<(Control control, string label, string message)>
            ValidateFormDetailed()
        {
            var errors =
                new List<(Control, string, string)>();

            if (string.IsNullOrWhiteSpace(txtColor.Text))
                errors.Add((txtColor, "Color", "Required"));

            if (numMileage.Value < _vehicle.Odometer)
                errors.Add((numMileage, "Mileage",
                    $"Must be ≥ {_vehicle.Odometer}"));

            if (!decimal.TryParse(txtFuelEfficiency.Text, out var eff) || eff <= 0)
                errors.Add((txtFuelEfficiency,
                    "Fuel Efficiency", "Must be > 0"));

            if (numCargoCapacity.Value <= 0)
                errors.Add((numCargoCapacity,
                    "Cargo Capacity", "Must be > 0"));

            return errors;
        }

        private void ShowValidationErrors(
            List<(Control control, string label, string message)> errors)
        {
            foreach (var e in errors)
                e.control.BackColor = _errorBackColor;

            errors[0].control.Focus();

            MessageBox.Show(
                "Fix the following:\n\n" +
                string.Join("\n",
                    errors.Select(e =>
                        $"• {e.label}: {e.message}")),
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void ResetErrorStyles()
        {
            txtColor.BackColor = _normalBackColor;
            numMileage.BackColor = _normalBackColor;
            txtFuelEfficiency.BackColor = _normalBackColor;
            numCargoCapacity.BackColor = _normalBackColor;
        }

        // =========================
        // CHANGE + SAVE STATE
        // =========================
        private bool HasChanges()
        {
            return
                txtColor.Text.Trim() != _vehicle.Color ||
                numMileage.Value != _vehicle.Odometer ||
                decimal.Parse(txtFuelEfficiency.Text) != _originalFuelEfficiency ||
                numCargoCapacity.Value != _originalCargoCapacity ||
                (VehicleStatus)cbStatus.SelectedItem! != _vehicle.Status ||
                FeaturesChanged();
        }

        private void UpdateSaveButtonState()
        {
            if (!_isLoaded)
            {
                SetSaveDisabled();
                return;
            }

            bool isValid =
                !string.IsNullOrWhiteSpace(txtColor.Text) &&
                numMileage.Value >= _vehicle.Odometer &&
                decimal.TryParse(txtFuelEfficiency.Text, out var eff) && eff > 0 &&
                numCargoCapacity.Value > 0;

            if (isValid && HasChanges())
                SetSaveEnabled();
            else
                SetSaveDisabled();
        }

        private void SetSaveEnabled()
        {
            btnSave.Enabled = true;
            btnSave.BackColor = _saveEnabledColor;
            btnSave.ForeColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
        }

        private void SetSaveDisabled()
        {
            btnSave.Enabled = false;
            btnSave.BackColor = _saveDisabledColor;
            btnSave.ForeColor = _saveDisabledTextColor;
            btnSave.Cursor = Cursors.Default;
        }
    }
}
