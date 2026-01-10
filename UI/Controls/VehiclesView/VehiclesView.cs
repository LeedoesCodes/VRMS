using System;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Forms;
using VRMS.Models.Fleet;

// Repositories
using VRMS.Repositories.Fleet;
using VRMS.Repositories.Rentals;
using VRMS.Repositories.Accounts;

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

        // =========================
        // CONSTRUCTOR
        // =========================

        public VehiclesView()
        {
            InitializeComponent();

            // =========================
            // REPOSITORIES (Fleet)
            // =========================

            var vehicleRepo = new VehicleRepository();
            var categoryRepo = new VehicleCategoryRepository();
            var featureRepo = new VehicleFeatureRepository();
            var featureMapRepo = new VehicleFeatureMappingRepository();
            var imageRepo = new VehicleImageRepository();
            var maintenanceRepo = new MaintenanceRepository();

            // =========================
            // SERVICES (Fleet)
            // =========================

            _vehicleService = new VehicleService(
                vehicleRepo,
                categoryRepo,
                featureRepo,
                featureMapRepo,
                imageRepo,
                maintenanceRepo
            );

            // =========================
            // CUSTOMER
            // =========================

            _driversLicenseService = new DriversLicenseService();
            _customerService = new CustomerService(_driversLicenseService);

            // =========================
            // RESERVATION
            // =========================

            var reservationRepo = new ReservationRepository();

            _reservationService = new ReservationService(
                _customerService,
                _vehicleService,
                reservationRepo
            );

            // =========================
            // RENTAL
            // =========================

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
                dgvVehicles.DataSource =
                    _vehicleService.GetAllVehicles();
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

            if (dgvVehicles.SelectedRows[0].DataBoundItem
                is not Vehicle vehicle)
                return;

            using var editForm =
                new EditVehicleForm(vehicle.Id, _vehicleService)
                {
                    StartPosition =
                        FormStartPosition.CenterParent
                };

            if (editForm.ShowDialog(this) ==
                DialogResult.OK)
                LoadVehicles();
        }
    }
}
