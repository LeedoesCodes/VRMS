using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Models.Fleet;
using VRMS.Enums;
using VRMS.Services.Fleet;
using VRMS.UI.Forms;

namespace VRMS.Forms
{
    public partial class AddVehicleForm : Form
    {
        private readonly VehicleService _vehicleService;

        public AddVehicleForm(VehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;

            HookEvents();
            Load += AddVehicleForm_Load;
        }

        // =========================
        // EVENT WIRING
        // =========================
        private void HookEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
            btnAddImage.Click += BtnSelectImage_Click;
            btnRemoveImage.Click += BtnRemoveImage_Click;
            btnAddCategory.Click += BtnAddCategory_Click;

            lstImages.SelectedIndexChanged += LstImages_SelectedIndexChanged;

            txtMake.TextChanged += ValidateFormState;
            txtModel.TextChanged += ValidateFormState;
            txtPlate.TextChanged += ValidateFormState;
            txtVIN.TextChanged += ValidateFormState;
            cbCategory.SelectedIndexChanged += ValidateFormState;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            cbTransmission.DataSource =
                Enum.GetValues(typeof(TransmissionType));

            cbFuel.DataSource =
                Enum.GetValues(typeof(FuelType));

            cbStatus.DataSource =
                new[] { VehicleStatus.Available };

            cbStatus.SelectedItem = VehicleStatus.Available;

            LoadCategories();
            btnSave.Enabled = false;
        }

        private void LoadCategories()
        {
            cbCategory.DataSource = null;
            cbCategory.DataSource = _vehicleService.GetAllCategories();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        // =========================
        // SAVE VEHICLE
        // =========================
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                ValidateForm();

                var vehicle = new Vehicle
                {
                    VehicleCode = $"VEH-{DateTime.UtcNow:yyyyMMddHHmmss}",
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

                    FuelEfficiency = decimal.TryParse(
                        txtFuelEfficiency.Text, out var eff) ? eff : 0,

                    CargoCapacity = (int)numCargoCapacity.Value,
                    VehicleCategoryId = (int)cbCategory.SelectedValue
                };

                int vehicleId = _vehicleService.CreateVehicle(vehicle);

                foreach (string path in lstImages.Items)
                {
                    using var stream = File.OpenRead(path);
                    _vehicleService.AddVehicleImage(
                        vehicleId,
                        stream,
                        Path.GetFileName(path));
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
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // VALIDATION
        // =========================
        private void ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
                throw new InvalidOperationException("Make is required.");

            if (string.IsNullOrWhiteSpace(txtModel.Text))
                throw new InvalidOperationException("Model is required.");

            if (string.IsNullOrWhiteSpace(txtPlate.Text))
                throw new InvalidOperationException("License plate is required.");

            if (string.IsNullOrWhiteSpace(txtVIN.Text))
                throw new InvalidOperationException("VIN is required.");

            if (txtVIN.Text.Length < 8)
                throw new InvalidOperationException("VIN is too short.");

            if (numMileage.Value < 0)
                throw new InvalidOperationException("Mileage cannot be negative.");

            if (cbCategory.SelectedItem == null)
                throw new InvalidOperationException("Category is required.");
        }

        private void ValidateFormState(object? sender, EventArgs e)
        {
            btnSave.Enabled =
                !string.IsNullOrWhiteSpace(txtMake.Text) &&
                !string.IsNullOrWhiteSpace(txtModel.Text) &&
                !string.IsNullOrWhiteSpace(txtPlate.Text) &&
                !string.IsNullOrWhiteSpace(txtVIN.Text) &&
                cbCategory.SelectedItem != null;
        }

        // =========================
        // IMAGE HANDLING
        // =========================
        private void BtnSelectImage_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dlg = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Multiselect = true,
                Title = "Select Vehicle Images"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            foreach (var file in dlg.FileNames)
            {
                if (!lstImages.Items.Contains(file))
                    lstImages.Items.Add(file);
            }

            if (lstImages.Items.Count > 0)
                lstImages.SelectedIndex = 0;
        }

        private void LstImages_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstImages.SelectedItem is string path &&
                File.Exists(path))
            {
                picVehicleImage.ImageLocation = path;
            }
        }

        private void BtnRemoveImage_Click(object? sender, EventArgs e)
        {
            if (lstImages.SelectedItem == null)
                return;

            int index = lstImages.SelectedIndex;
            lstImages.Items.RemoveAt(index);

            picVehicleImage.Image = null;

            if (lstImages.Items.Count > 0)
                lstImages.SelectedIndex = Math.Max(0, index - 1);
        }

        // =========================
        // ADD CATEGORY
        // =========================
        private void BtnAddCategory_Click(object? sender, EventArgs e)
        {
            using var form = new AddCategoryForm(_vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (form.ShowDialog(this) == DialogResult.OK)
                LoadCategories();
        }
    }
}
