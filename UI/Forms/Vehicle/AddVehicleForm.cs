using System;
using System.Windows.Forms;
using VRMS.Services;
using VRMS.Models.Fleet;
using VRMS.Enums;

namespace VRMS.Forms
{
    public partial class AddVehicleForm : Form
    {
        private readonly VehicleService _vehicleService = new();

        public AddVehicleForm()
        {
            InitializeComponent();

            Load += AddVehicleForm_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnAddImage.Click += btnSelectImage_Click;
        }

        // =========================
        // FORM LOAD
        // =========================

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            // Populate enum-based dropdowns
            cbTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));
            cbFuel.DataSource = Enum.GetValues(typeof(FuelType));

            cbStatus.DataSource = Enum.GetValues(typeof(VehicleStatus));
            cbStatus.SelectedItem = VehicleStatus.Available;

            // TODO (optional): load categories from DB later
            // For now, your designer already has items
        }

        // =========================
        // SAVE VEHICLE
        // =========================

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                ValidateForm();

                var vehicle = new Vehicle
                {
                    VehicleCode = txtVehicleCode.Text.Trim(),
                    Make = txtMake.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Year = (int)numYear.Value,
                    Color = txtColor.Text.Trim(),
                    LicensePlate = txtPlate.Text.Trim(),
                    VIN = txtVIN.Text.Trim(),

                    Transmission = (TransmissionType)cbTransmission.SelectedItem!,
                    FuelType = (FuelType)cbFuel.SelectedItem!,
                    SeatingCapacity = (int)numSeats.Value,
                    Odometer = (int)numMileage.Value,

                    // 🔹 TEMP: category ID (replace later with real categories)
                    VehicleCategoryId = 1
                };

                int vehicleId = _vehicleService.CreateVehicle(vehicle);

                // 🔹 Status update if not default
                var selectedStatus = (VehicleStatus)cbStatus.SelectedItem!;
                if (selectedStatus != VehicleStatus.Available)
                {
                    _vehicleService.UpdateVehicleStatus(vehicleId, selectedStatus);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Add Vehicle Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // VALIDATION
        // =========================

        private void ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtVehicleCode.Text))
                throw new InvalidOperationException("Vehicle Code is required.");

            if (string.IsNullOrWhiteSpace(txtMake.Text))
                throw new InvalidOperationException("Make is required.");

            if (string.IsNullOrWhiteSpace(txtModel.Text))
                throw new InvalidOperationException("Model is required.");

            if (string.IsNullOrWhiteSpace(txtPlate.Text))
                throw new InvalidOperationException("License Plate is required.");

            if (string.IsNullOrWhiteSpace(txtVIN.Text))
                throw new InvalidOperationException("VIN is required.");

            if (txtVIN.Text.Length < 8)
                throw new InvalidOperationException("VIN is too short.");

            if (numMileage.Value < 0)
                throw new InvalidOperationException("Mileage cannot be negative.");
        }

        // =========================
        // IMAGE HANDLING (BASIC)
        // =========================

        private void btnSelectImage_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dlg = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select Vehicle Image"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picVehicleImage.ImageLocation = dlg.FileName;
                lstImages.Items.Add(dlg.FileName);
            }
        }

        // =========================
        // CANCEL
        // =========================

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
