using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Forms;
using VRMS.Models.Fleet;

// Repositories
using VRMS.Repositories.Fleet;
using VRMS.Repositories.Rentals;

// Services
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.Controls
{
    public partial class VehiclesView : UserControl
    {
        // =========================
        // SERVICES
        // =========================

        private readonly VehicleService _vehicleService;
        private readonly DriversLicenseService _driversLicenseService;
        private readonly CustomerService _customerService;
        private readonly ReservationService _reservationService;
        private readonly RentalService _rentalService;

        private static readonly string StorageRoot =
            Path.Combine(AppContext.BaseDirectory, "Storage");

        // =========================
        // CONSTRUCTOR
        // =========================

        public VehiclesView()
        {
            InitializeComponent();

            // -------------------------
            // REPOSITORIES
            // -------------------------

            var vehicleRepo = new VehicleRepository();
            var categoryRepo = new VehicleCategoryRepository();
            var featureRepo = new VehicleFeatureRepository();
            var featureMapRepo = new VehicleFeatureMappingRepository();
            var imageRepo = new VehicleImageRepository();
            var maintenanceRepo = new MaintenanceRepository();

            // -------------------------
            // SERVICES
            // -------------------------

            _vehicleService = new VehicleService(
                vehicleRepo,
                categoryRepo,
                featureRepo,
                featureMapRepo,
                imageRepo,
                maintenanceRepo
            );

            _driversLicenseService = new DriversLicenseService();
            _customerService = new CustomerService(_driversLicenseService);

            var reservationRepo = new ReservationRepository();
            _reservationService = new ReservationService(
                _customerService,
                _vehicleService,
                reservationRepo
            );

            var rentalRepo = new RentalRepository();
            _rentalService = new RentalService(
                _reservationService,
                _vehicleService,
                rentalRepo
            );

            Load += VehiclesView_Load;
        }

        // =========================
        // LOAD
        // =========================

        private void VehiclesView_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            LoadVehicles();

            dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
        }

        private void ConfigureGrid()
        {
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.MultiSelect = false;
            dgvVehicles.ReadOnly = true;

            dgvVehicles.Columns.Clear();

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Make",
                DataPropertyName = "Make"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "Model"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Year",
                DataPropertyName = "Year"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plate No.",
                DataPropertyName = "LicensePlate"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Transmission",
                DataPropertyName = "Transmission"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fuel",
                DataPropertyName = "FuelType"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Odometer",
                DataPropertyName = "Odometer"
            });
        }

        private void LoadVehicles()
        {
            try
            {
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = _vehicleService.GetAllVehicles();

                picVehiclePreview.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Load Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // IMAGE PREVIEW
        // =========================

        private void DgvVehicles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                picVehiclePreview.Image = null;
                return;
            }

            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle)
                return;

            LoadVehiclePreview(vehicle.Id);
        }

        private void LoadVehiclePreview(int vehicleId)
        {
            try
            {
                picVehiclePreview.Image = null;

                var images = _vehicleService.GetVehicleImages(vehicleId);

                if (images.Count == 0)
                    return;

                // Take FIRST image as preview
                var image = images.First();
                var fullPath = Path.Combine(StorageRoot, image.ImagePath);

                if (!File.Exists(fullPath))
                    return;

                // Prevent file lock
                using var fs = new FileStream(
                    fullPath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite);

                picVehiclePreview.Image = System.Drawing.Image.FromStream(fs);
            }
            catch
            {
                // Never crash UI due to image issues
                picVehiclePreview.Image = null;
            }
        }

        // =========================
        // ADD VEHICLE
        // =========================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddVehicleForm(_vehicleService)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (addForm.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }

        // =========================
        // EDIT VEHICLE
        // =========================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
                return;

            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle)
                return;

            using var editForm =
                new EditVehicleForm(vehicle.Id, _vehicleService)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

            if (editForm.ShowDialog(this) == DialogResult.OK)
                LoadVehicles();
        }
    }
}
