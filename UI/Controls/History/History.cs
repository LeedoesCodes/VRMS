using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Services.Rental;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.UI.ApplicationService;

namespace VRMS.UI.Controls.History
{
    public partial class History : UserControl
    {
        private readonly RentalService _rentalService;
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;
        private readonly ReservationService _reservationService;

        private static readonly string PlaceholderImagePath =
            Path.Combine(AppContext.BaseDirectory, "Assets", "img_placeholder.png");

        public History()
        {
            InitializeComponent();

            _rentalService = ApplicationServices.RentalService;
            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;
            _reservationService = ApplicationServices.ReservationService;

            // FORM LOAD
            Load += History_Load;

            // GRID EVENTS
            dgvRentals.SelectionChanged += DgvRentals_SelectionChanged;
            dgvReservations.SelectionChanged += DgvReservations_SelectionChanged;
            dgvReservations.CellFormatting += DgvReservations_CellFormatting;

            // TAB CHANGE
            tabControlHistory.SelectedIndexChanged += TabControlHistory_SelectedIndexChanged;

            // BUTTONS
            btnViewReceipt.Click += BtnViewReceipt_Click;
            btnRefund.Click += BtnRefund_Click;
        }

        // =====================================================
        // LOAD
        // =====================================================

        private void History_Load(object sender, EventArgs e)
        {
            ConfigureRentalsGrid();
            LoadRentals();
            LoadReservations();
            ResetDetails();
        }

        // =====================================================
        // GRID SETUP
        // =====================================================

        private void ConfigureRentalsGrid()
        {
            dgvRentals.AutoGenerateColumns = false;
            dgvRentals.Columns.Clear();
            dgvRentals.ReadOnly = true;
            dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentals.MultiSelect = false;

            dgvRentals.Columns.Add("Id", "ID");
            dgvRentals.Columns.Add("Vehicle", "Vehicle");
            dgvRentals.Columns.Add("Dates", "Dates");
            dgvRentals.Columns.Add("Status", "Status");
            dgvRentals.Columns.Add("Amount", "Amount");
            dgvRentals.Columns.Add("Odometer", "Odometer");

            dgvRentals.Columns["Id"].Width = 60;
            dgvRentals.Columns["Status"].Width = 100;

            dgvRentals.CellFormatting += DgvRentals_CellFormatting;
        }

        // =====================================================
        // LOAD DATA
        // =====================================================

        private void LoadRentals()
        {
            dgvRentals.Rows.Clear();

            var rentals = _rentalService
                .GetAllRentals()
                .OrderByDescending(r => r.PickupDate)
                .ToList();

            foreach (var r in rentals)
            {
                var vehicle = _vehicleService.GetVehicleById(r.VehicleId);

                dgvRentals.Rows.Add(
                    r.Id,
                    $"{vehicle.Make} {vehicle.Model}",
                    $"{r.PickupDate:MMM dd, yyyy} → {r.ExpectedReturnDate:MMM dd, yyyy}",
                    r.Status.ToString(),
                    "—",
                    r.EndOdometer?.ToString() ?? "-"
                );
            }

            lblSummary.Text = $"Total Rentals: {rentals.Count}";
        }

        private void LoadReservations()
        {
            dgvReservations.Rows.Clear();

            var reservations = _reservationService
                .GetAllForGrid()
                .OrderByDescending(r => r.StartDate)
                .ToList();

            foreach (var r in reservations)
            {
                dgvReservations.Rows.Add(
                    r.ReservationId,
                    r.VehicleName,
                    $"{r.StartDate:MMM dd, yyyy} → {r.EndDate:MMM dd, yyyy}",
                    r.Status.ToString(),
                    "—"
                );
            }

            lblSummary.Text =
                $"Total: {reservations.Count} reservations | {_rentalService.GetAllRentals().Count} rentals";
        }

        // =====================================================
        // STATUS STYLING
        // =====================================================

        private void DgvRentals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRentals.Columns[e.ColumnIndex].Name != "Status")
                return;

            if (e.Value is not string status)
                return;

            e.CellStyle.Font = new Font(dgvRentals.Font, FontStyle.Bold);

            e.CellStyle.ForeColor = status switch
            {
                nameof(RentalStatus.Active) => Color.Green,
                nameof(RentalStatus.Late) => Color.OrangeRed,
                nameof(RentalStatus.Completed) => Color.Gray,
                nameof(RentalStatus.Cancelled) => Color.DarkGray,
                _ => e.CellStyle.ForeColor
            };
        }

        private void DgvReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReservations.Columns[e.ColumnIndex].Name != "Status")
                return;

            if (e.Value is not string status)
                return;

            e.CellStyle.Font = new Font(dgvReservations.Font, FontStyle.Bold);

            e.CellStyle.ForeColor = status switch
            {
                nameof(ReservationStatus.Pending) => Color.Orange,
                nameof(ReservationStatus.Confirmed) => Color.Green,
                nameof(ReservationStatus.Rented) => Color.Blue,
                nameof(ReservationStatus.Cancelled) => Color.DarkGray,
                _ => e.CellStyle.ForeColor
            };
        }

        // =====================================================
        // SELECTION → DETAILS
        // =====================================================

        private void DgvRentals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count == 0)
            {
                ResetDetails();
                return;
            }

            int rentalId = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells["Id"].Value);
            var rental = _rentalService.GetRentalById(rentalId);
            var vehicle = _vehicleService.GetVehicleById(rental.VehicleId);

            string customerName = "Walk-in";
            if (rental.CustomerId.HasValue)
            {
                var customer = _customerService.GetCustomerById(rental.CustomerId.Value);
                customerName = $"{customer.FirstName} {customer.LastName}";
            }

            lblReservationIdValue.Text = rental.Id.ToString();
            lblStatusValue.Text = rental.Status.ToString();
            lblDatesValue.Text = $"{rental.PickupDate:d} → {rental.ExpectedReturnDate:d}";
            lblCustomerValue.Text = customerName;
            lblVehicleName.Text = $"{vehicle.Make} {vehicle.Model}";
            lblAmountValue.Text = "—";
            lblPaymentValue.Text = "—";
            lblCreatedValue.Text = rental.PickupDate.ToString("yyyy-MM-dd");

            LoadVehicleImage(vehicle.Id);

            panelNoSelection.Visible = false;
            panelDetailsContent.Visible = true;

            btnViewReceipt.Enabled = true;
            btnRefund.Enabled = false;
        }

        private void DgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            ResetDetails();
            btnViewReceipt.Enabled = false;
            btnRefund.Enabled = false;
        }

        // =====================================================
        // VEHICLE IMAGE
        // =====================================================

        private void LoadVehicleImage(int vehicleId)
        {
            picVehicle.Image?.Dispose();
            picVehicle.Image = null;

            var images = _vehicleService.GetVehicleImages(vehicleId);
            string imagePath = images.Count > 0
                ? Path.Combine(AppContext.BaseDirectory, "Storage", images[0].ImagePath)
                : PlaceholderImagePath;

            if (!File.Exists(imagePath))
                return;

            using var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            picVehicle.Image = Image.FromStream(fs);
        }

        // =====================================================
        // BUTTONS
        // =====================================================

        private void BtnViewReceipt_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count == 0)
                return;

            int rentalId = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells["Id"].Value);

            using var form = new VRMS.UI.Forms.Receipts.ReceiptForm(rentalId);
            form.ShowDialog(FindForm());
        }

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Refunds are disabled until billing is complete.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // TAB CHANGE
        // =====================================================

        private void TabControlHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDetails();

            if (tabControlHistory.SelectedTab == tabRentals)
                LoadRentals();
            else if (tabControlHistory.SelectedTab == tabReservations)
                LoadReservations();

            btnViewReceipt.Enabled = false;
            btnRefund.Enabled = false;
        }

        // =====================================================
        // RESET
        // =====================================================

        private void ResetDetails()
        {
            panelDetailsContent.Visible = false;
            panelNoSelection.Visible = true;
        }
    }
}
