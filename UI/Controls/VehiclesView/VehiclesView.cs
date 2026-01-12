using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Forms;
using VRMS.Models.Fleet;
using VRMS.Repositories.Billing;

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

        // =========================
        // UI-ONLY REPO (TEMPORARY)
        // =========================
        private readonly VehicleImageRepository _vehicleImageRepo;

        // =========================
        // CONSTRUCTOR
        // =========================
        public VehiclesView()
        {
            InitializeComponent();

            // -------------------------
            // Repositories
            // -------------------------
            var vehicleRepo = new VehicleRepository();
            var categoryRepo = new VehicleCategoryRepository();
            var featureRepo = new VehicleFeatureRepository();
            var featureMapRepo = new VehicleFeatureMappingRepository();
            var imageRepo = new VehicleImageRepository();
            var maintenanceRepo = new MaintenanceRepository();

            var reservationRepo = new ReservationRepository();
            var rentalRepo = new RentalRepository();
            var rateConfigRepo = new RateConfigurationRepository();

            _vehicleImageRepo = imageRepo;

            // -------------------------
            // Services
            // -------------------------
            _vehicleService = new VehicleService(
                vehicleRepo,
                categoryRepo,
                featureRepo,
                featureMapRepo,
                imageRepo,
                maintenanceRepo,
                rateConfigRepo
            );

            _driversLicenseService = new DriversLicenseService();
            _customerService = new CustomerService(_driversLicenseService);

            _reservationService = new ReservationService(
                _customerService,
                _vehicleService,
                reservationRepo
            );

            _rentalService = new RentalService(
                _reservationService,
                _vehicleService,
                rentalRepo,
                null
            );

            // -------------------------
            // Events
            // -------------------------
            Load += VehiclesView_Load;
            dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;

            // Fix the FlowLayoutPanel size
            flowLayoutPanelFeatures.AutoSize = true;
            flowLayoutPanelFeatures.WrapContents = true;
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
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = _vehicleService.GetAllVehicles();

            lblVehicleCount.Text =
                $"Total: {dgvVehicles.Rows.Count} vehicles";

            ClearVehiclePreview();
        }

        // =========================
        // SELECTION
        // =========================
        private void DgvVehicles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                ClearVehiclePreview();
                return;
            }

            if (dgvVehicles.SelectedRows[0].DataBoundItem is not Vehicle vehicle)
            {
                ClearVehiclePreview();
                return;
            }

            LoadVehiclePreview(vehicle);
        }

        // =========================
        // PREVIEW
        // =========================
        private void LoadVehiclePreview(Vehicle vehicle)
        {
            // Load basic vehicle info
            lblMakeModel.Text = $"{vehicle.Make} {vehicle.Model}";
            lblPlateValue.Text = vehicle.LicensePlate;
            lblMileageValue.Text = $"{vehicle.Odometer:N0} km";
            lblYearColorValue.Text = $"{vehicle.Year}/{vehicle.Color}";
            lblDailyRateValue.Text = vehicle.FuelEfficiency.ToString("N2");

            // Load category
            try
            {
                var category = _vehicleService.GetCategoryById(vehicle.VehicleCategoryId);
                lblCategoryValue.Text = category.Name;
            }
            catch
            {
                lblCategoryValue.Text = "Unknown";
            }

            // Set status with color
            lblStatusValue.Text = vehicle.Status.ToString();
            lblStatusValue.ForeColor = GetStatusColor(vehicle.Status);

            // Load vehicle image
            LoadVehicleImage(vehicle.Id);

            // Load vehicle features
            LoadVehicleFeatures(vehicle.Id);
        }

        private Color GetStatusColor(VehicleStatus status)
        {
            return status switch
            {
                VehicleStatus.Available => Color.FromArgb(46, 204, 113),      // Green
                VehicleStatus.Rented => Color.FromArgb(231, 76, 60),          // Red
                VehicleStatus.UnderMaintenance => Color.FromArgb(243, 156, 18), // Orange
                VehicleStatus.Reserved => Color.FromArgb(155, 89, 182),       // Purple
                VehicleStatus.OutOfService => Color.FromArgb(149, 165, 166),  // Gray
                VehicleStatus.Retired => Color.FromArgb(52, 73, 94),          // Dark blue
                _ => Color.Gray
            };
        }

        private void LoadVehicleImage(int vehicleId)
        {
            try
            {
                var images = _vehicleImageRepo.GetByVehicle(vehicleId);

                if (images == null || images.Count == 0)
                {
                    picVehiclePreview.Image = null;
                    return;
                }

                // DB stores RELATIVE path: Vehicles/{id}/{file}
                var relativePath = images[0].ImagePath;

                var fullPath = Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    relativePath
                );

                if (!File.Exists(fullPath))
                {
                    picVehiclePreview.Image = null;
                    return;
                }

                // Prevent file locking
                using var fs = new FileStream(
                    fullPath,
                    FileMode.Open,
                    FileAccess.Read
                );

                picVehiclePreview.Image = Image.FromStream(fs);
            }
            catch
            {
                picVehiclePreview.Image = null;
            }
        }

        // =========================
        // FEATURES DISPLAY
        // =========================
        private void LoadVehicleFeatures(int vehicleId)
        {
            // Clear existing features
            flowLayoutPanelFeatures.Controls.Clear();

            try
            {
                // Get features for this vehicle
                var features = _vehicleService.GetVehicleFeatures(vehicleId);

                if (features == null || features.Count == 0)
                {
                    // Show "No features" message
                    var noFeaturesLabel = new Label
                    {
                        Text = "No features available",
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                        AutoSize = true,
                        Margin = new Padding(5, 3, 5, 3)
                    };
                    flowLayoutPanelFeatures.Controls.Add(noFeaturesLabel);
                    return;
                }

                // Display each feature as a badge
                foreach (var feature in features)
                {
                    var featureBadge = CreateFeatureBadge(feature.Name);
                    flowLayoutPanelFeatures.Controls.Add(featureBadge);
                }

                // Update features title with count
                lblFeaturesTitle.Text = $"Features ({features.Count})";
            }
            catch (Exception ex)
            {
                // Show error message
                var errorLabel = new Label
                {
                    Text = $"Error loading features: {ex.Message}",
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 8F),
                    AutoSize = true,
                    Margin = new Padding(5, 3, 5, 3)
                };
                flowLayoutPanelFeatures.Controls.Add(errorLabel);
                lblFeaturesTitle.Text = "Features (Error)";
            }
        }

        private Control CreateFeatureBadge(string featureName)
        {
            // Create a panel as the badge container
            var badgePanel = new Panel
            {
                BackColor = Color.FromArgb(236, 240, 241), // Light gray background
                ForeColor = Color.FromArgb(52, 73, 94),    // Dark blue text
                Padding = new Padding(6, 3, 6, 3),
                Margin = new Padding(2, 2, 2, 2),
                AutoSize = true,
                MinimumSize = new Size(100, 26)
            };

            // Add a label inside the panel
            var badgeLabel = new Label
            {
                Text = GetFeatureIcon(featureName) + " " + featureName,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(52, 73, 94),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 0, 0, 0)
            };

            badgePanel.Controls.Add(badgeLabel);
            return badgePanel;
        }

        private string GetFeatureIcon(string featureName)
        {
            // Map feature names to appropriate icons
            return featureName.ToLower() switch
            {
                string f when f.Contains("air conditioning") || f.Contains("ac") => "❄",
                string f when f.Contains("gps") || f.Contains("navigation") => "📍",
                string f when f.Contains("bluetooth") => "📱",
                string f when f.Contains("child") || f.Contains("seat") => "👶",
                string f when f.Contains("insurance") => "🛡",
                string f when f.Contains("camera") => "📷",
                string f when f.Contains("heated") || f.Contains("seat") => "🔥",
                string f when f.Contains("sunroof") || f.Contains("moonroof") => "☀",
                string f when f.Contains("leather") => "💺",
                _ => "✓"
            };
        }

        private void ClearVehiclePreview()
        {
            // Clear image
            picVehiclePreview.Image = null;

            // Clear labels
            lblMakeModel.Text = "—";
            lblPlateValue.Text = "—";
            lblMileageValue.Text = "—";
            lblYearColorValue.Text = "—";
            lblDailyRateValue.Text = "—";
            lblStatusValue.Text = "—";
            lblCategoryValue.Text = "—";

            // Clear features
            flowLayoutPanelFeatures.Controls.Clear();
            var noSelectionLabel = new Label
            {
                Text = "Select a vehicle to view features",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                AutoSize = true,
                Margin = new Padding(5, 3, 5, 3)
            };
            flowLayoutPanelFeatures.Controls.Add(noSelectionLabel);
            lblFeaturesTitle.Text = "Features";
        }

        // =========================
        // ADD
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
        // EDIT
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