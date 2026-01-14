using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;
using VRMS.UI.ApplicationService;


namespace VRMS.Forms
{
    public partial class RentalDetailsForm : Form
    {
        private readonly int _rentalId;

        private readonly RentalService _rentalService;
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;

        private static readonly string PlaceholderImagePath =
            Path.Combine(AppContext.BaseDirectory, "Assets", "img_placeholder.png");

        // ✅ MAIN CONSTRUCTOR (USE THIS)
        public RentalDetailsForm(int rentalId)
        {
            InitializeComponent();

            _rentalId = rentalId;

            _rentalService = ApplicationServices.RentalService;
            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;

            Load += RentalDetailsForm_Load;
            btnClose.Click += (_, __) => Close();
        }

        // ⚠️ DESIGNER SUPPORT ONLY
        public RentalDetailsForm()
        {
            InitializeComponent();
            btnClose.Click += (_, __) => Close();
        }

        // =====================================================
        // LOAD
        // =====================================================

        private void RentalDetailsForm_Load(object sender, EventArgs e)
        {
            ConfigureDamageGrid();
            LoadRentalDetails();
        }

        // =====================================================
        // LOAD RENTAL DATA
        // =====================================================

        private void LoadRentalDetails()
        {
            var rental =
                _rentalService.GetRentalById(_rentalId);

            var vehicle =
                _vehicleService.GetVehicleById(rental.VehicleId);

            string customerName = "Walk-in";

            if (rental.CustomerId.HasValue)
            {
                var customer =
                    _customerService.GetCustomerById(rental.CustomerId.Value);

                customerName =
                    $"{customer.FirstName} {customer.LastName}";
            }

            // -----------------------------
            // SUMMARY
            // -----------------------------

            lblRentalID.Text = $"Rental ID: {rental.Id}";
            lblCustomer.Text = $"Customer: {customerName}";
            lblVehicle.Text =
                $"Vehicle: {vehicle.Make} {vehicle.Model} ({vehicle.LicensePlate})";

            lblTotalDate.Text =
                rental.Status == RentalStatus.Completed || rental.Status == RentalStatus.Late
                    ? $"Returned: {rental.ActualReturnDate:MMM dd, yyyy}"
                    : $"Expected Return: {rental.ExpectedReturnDate:MMM dd, yyyy}";

            // -----------------------------
            // DAMAGES (EMPTY FOR NOW)
            // -----------------------------

            dgvDamages.Rows.Clear();

            // 💡 Until damage module is wired
            // you can safely leave this empty
            // or add a placeholder row:
            // dgvDamages.Rows.Add("No damages recorded", "₱0.00");

            // -----------------------------
            // EVIDENCE IMAGE
            // -----------------------------

            LoadEvidenceImage(vehicle.Id);
        }

        // =====================================================
        // DAMAGE GRID
        // =====================================================

        private void ConfigureDamageGrid()
        {
            dgvDamages.AutoGenerateColumns = false;
            dgvDamages.Columns.Clear();

            dgvDamages.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Description",
                    Width = 350
                });

            dgvDamages.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Estimated Cost",
                    Width = 150
                });
        }

        // =====================================================
        // IMAGE LOADER
        // =====================================================

        private void LoadEvidenceImage(int vehicleId)
        {
            if (pbEvidence.Image != null)
            {
                pbEvidence.Image.Dispose();
                pbEvidence.Image = null;
            }

            var images =
                _vehicleService.GetVehicleImages(vehicleId);

            string? imagePath =
                images.Count > 0
                    ? Path.Combine(
                        AppContext.BaseDirectory,
                        "Storage",
                        images[0].ImagePath)
                    : null;

            if (string.IsNullOrWhiteSpace(imagePath) ||
                !File.Exists(imagePath))
            {
                imagePath = PlaceholderImagePath;
                if (!File.Exists(imagePath))
                    return;
            }

            using var fs =
                new FileStream(
                    imagePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite);

            pbEvidence.Image = Image.FromStream(fs);
        }
    }
}
