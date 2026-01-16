using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Billing;
using VRMS.Services.Rental;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.UI.ApplicationService;
using VRMS.Repositories.Billing;

namespace VRMS.UI.Controls.History
{
    public partial class History : UserControl
    {
        private readonly RentalService _rentalService;
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;

        private Invoice? _selectedInvoice;
        private Payment? _lastPayment;

        private bool _suspendSelectionEvents;
        private int? _lastSelectedRentalId;

        private static readonly string PlaceholderImagePath =
            Path.Combine(AppContext.BaseDirectory, "Assets", "img_placeholder.png");

        public History()
        {
            InitializeComponent();

            _rentalService = ApplicationServices.RentalService;
            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;

            Load += History_Load;
            dgvRentals.SelectionChanged += DgvRentals_SelectionChanged;

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
            ResetDetails();
        }

        // =====================================================
        // GRID SETUP
        // =====================================================

        private void ConfigureRentalsGrid()
        {
            dgvRentals.AutoGenerateColumns = false;
            dgvRentals.ReadOnly = true;
            dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentals.MultiSelect = false;
        }

        // =====================================================
        // LOAD RENTALS
        // =====================================================

        private void LoadRentals()
        {
            dgvRentals.Rows.Clear();

            var rentals = _rentalService
                .GetAllRentals()
                .OrderByDescending(r => r.PickupDate)
                .ToList();

            var billingService = ApplicationServices.BillingService;
            var lineRepo = new InvoiceLineItemRepository();

            foreach (var r in rentals)
            {
                var vehicle = _vehicleService.GetVehicleById(r.VehicleId);

                string amountText = "—";

                var invoice = billingService.GetInvoiceByRental(r.Id);
                if (invoice != null)
                {
                    var items = lineRepo.GetByInvoice(invoice.Id);

                    decimal chargeOnly =
                        items
                            .Where(i => i.Description != "Security deposit")
                            .Sum(i => i.Amount);

                    amountText = $"₱ {chargeOnly:N2}";
                }

                dgvRentals.Rows.Add(
                    r.Id,
                    $"{vehicle.Make} {vehicle.Model}",
                    $"{r.PickupDate:MMM dd, yyyy} → {r.ExpectedReturnDate:MMM dd, yyyy}",
                    r.Status.ToString(),
                    amountText,
                    r.EndOdometer?.ToString() ?? "-"
                );
            }

            lblSummary.Text = $"Total Rentals: {rentals.Count}";
        }

        // =====================================================
        // SELECTION → DETAILS (SAFE)
        // =====================================================

        private void DgvRentals_SelectionChanged(object sender, EventArgs e)
        {
            if (_suspendSelectionEvents)
                return;

            if (dgvRentals.SelectedRows.Count == 0)
            {
                ResetDetails();
                return;
            }

            int rentalId =
                Convert.ToInt32(
                    dgvRentals.SelectedRows[0].Cells[0].Value);

            if (_lastSelectedRentalId == rentalId)
                return;

            _lastSelectedRentalId = rentalId;

            var rental = _rentalService.GetRentalById(rentalId);
            var billingService = ApplicationServices.BillingService;
            var lineRepo = new InvoiceLineItemRepository();

            _selectedInvoice = billingService.GetInvoiceByRental(rentalId);
            _lastPayment = null;

            if (_selectedInvoice != null)
            {
                var payments =
                    billingService.GetPaymentsByInvoice(_selectedInvoice.Id);

                _lastPayment = payments
                    .Where(p => p.PaymentType != PaymentType.Refund)
                    .OrderByDescending(p => p.PaymentDate)
                    .FirstOrDefault();
            }

            var vehicle = _vehicleService.GetVehicleById(rental.VehicleId);

            string customerName = "Walk-in";
            if (rental.CustomerId.HasValue)
            {
                var customer =
                    _customerService.GetCustomerById(rental.CustomerId.Value);
                customerName = $"{customer.FirstName} {customer.LastName}";
            }

            lblReservationIdValue.Text = rental.Id.ToString();
            lblStatusValue.Text = rental.Status.ToString();
            lblDatesValue.Text = $"{rental.PickupDate:d} → {rental.ExpectedReturnDate:d}";
            lblCustomerValue.Text = customerName;
            lblVehicleName.Text = $"{vehicle.Make} {vehicle.Model}";
            lblCreatedValue.Text = rental.PickupDate.ToString("yyyy-MM-dd");

            // ===== Amount (NO DEPOSIT) =====
            if (_selectedInvoice != null)
            {
                var items = lineRepo.GetByInvoice(_selectedInvoice.Id);

                decimal chargeOnly =
                    items
                        .Where(i => i.Description != "Security deposit")
                        .Sum(i => i.Amount);

                lblAmountValue.Text = $"₱ {chargeOnly:N2}";
            }
            else
            {
                lblAmountValue.Text = "—";
            }

            lblPaymentValue.Text =
                _lastPayment != null
                    ? $"{_lastPayment.PaymentType} - {_lastPayment.PaymentMethod}"
                    : "—";

            LoadVehicleImage(vehicle.Id);

            panelNoSelection.Visible = false;
            panelDetailsContent.Visible = true;

            btnViewReceipt.Enabled = true;
            btnRefund.Enabled =
                _selectedInvoice != null &&
                _lastPayment != null;
        }

        // =====================================================
        // VEHICLE IMAGE
        // =====================================================

        private void LoadVehicleImage(int vehicleId)
        {
            if (picVehicle.Image != null)
            {
                var old = picVehicle.Image;
                picVehicle.Image = null;
                old.Dispose();
            }

            var images = _vehicleService.GetVehicleImages(vehicleId);

            string imagePath =
                images.Count > 0
                    ? Path.Combine(AppContext.BaseDirectory, "Storage", images[0].ImagePath)
                    : PlaceholderImagePath;

            if (!File.Exists(imagePath))
                return;

            using var fs =
                new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var temp = Image.FromStream(fs);
            picVehicle.Image = new Bitmap(temp);
        }

        // =====================================================
        // BUTTONS
        // =====================================================

        private void BtnViewReceipt_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count == 0)
                return;

            int rentalId =
                Convert.ToInt32(
                    dgvRentals.SelectedRows[0].Cells[0].Value);

            _suspendSelectionEvents = true;

            try
            {
                using var form =
                    new VRMS.UI.Forms.Receipts.ReceiptForm(rentalId);

                form.ShowDialog(this);
            }
            finally
            {
                BeginInvoke(new Action(() =>
                {
                    _suspendSelectionEvents = false;
                    _lastSelectedRentalId = null;
                    dgvRentals.ClearSelection();
                    ResetDetails();
                }));
            }
        }

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Refunds are handled via billing flow.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
