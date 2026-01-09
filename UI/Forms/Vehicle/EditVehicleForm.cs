using System;
using System.Windows.Forms;
using VRMS.Services;
using VRMS.Models.Fleet;
using VRMS.Enums;

namespace VRMS.Forms
{
    public partial class EditVehicleForm : Form
    {
        private readonly int _vehicleId;
        private readonly VehicleService _vehicleService = new();
        private Vehicle _vehicle = null!;

        // ✅ THIS IS THE MISSING CONSTRUCTOR
        public EditVehicleForm(int vehicleId)
        {
            InitializeComponent();
            _vehicleId = vehicleId;

            Load += EditVehicleForm_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // =========================
        // LOAD VEHICLE DATA
        // =========================

        private void EditVehicleForm_Load(object sender, EventArgs e)
        {
            try
            {
                _vehicle = _vehicleService.GetVehicleFull(_vehicleId);
                PopulateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Close();
            }
        }

        private void PopulateForm()
        {
            txtVehicleCode.Text = _vehicle.VehicleCode;
            txtMake.Text = _vehicle.Make;
            txtModel.Text = _vehicle.Model;
            numYear.Value = _vehicle.Year;
            txtColor.Text = _vehicle.Color;
            txtPlate.Text = _vehicle.LicensePlate;
            txtVIN.Text = _vehicle.VIN;

            cbTransmission.SelectedItem = _vehicle.Transmission.ToString();
            cbFuel.SelectedItem = _vehicle.FuelType.ToString();
            cbStatus.SelectedItem = _vehicle.Status.ToString();

            numSeats.Value = _vehicle.SeatingCapacity;
            numMileage.Value = _vehicle.Odometer;
        }

        // =========================
        // SAVE CHANGES
        // =========================

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // 🔹 Update allowed fields only (matches your service)
                _vehicleService.UpdateVehicle(
                    _vehicleId,
                    txtColor.Text.Trim(),
                    (int)numMileage.Value,
                    _vehicle.VehicleCategoryId
                );

                // 🔹 Status change handled separately
                var newStatus = Enum.Parse<VehicleStatus>(cbStatus.SelectedItem!.ToString()!);
                if (newStatus != _vehicle.Status)
                {
                    _vehicleService.UpdateVehicleStatus(_vehicleId, newStatus);
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

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
