// History.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VRMS.UI.Controls.History
{
    public partial class History : UserControl
    {
        // ===== UI COLORS =====
        private readonly Color _successColor = Color.FromArgb(46, 204, 113);   // green
        private readonly Color _dangerColor = Color.FromArgb(231, 76, 60);     // red
        private readonly Color _warningColor = Color.FromArgb(243, 156, 18);   // orange
        private readonly Color _infoColor = Color.FromArgb(52, 152, 219);      // blue
        private readonly Color _mutedColor = Color.FromArgb(108, 117, 125);    // gray

        private List<ReservationRecord> _reservations = new List<ReservationRecord>();
        private List<RentalRecord> _rentals = new List<RentalRecord>();
        private object? _selectedRecord;

        public History()
        {
            InitializeComponent();
            SetupDataGridViews();
            WireEvents();
            LoadSampleData(); // Replace with actual data loading
            UpdateSummary();
        }

        private void SetupDataGridViews()
        {
            // Setup Reservations DataGridView Columns
            dgvReservations.Columns.Clear();
            dgvReservations.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "colResId", HeaderText = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "colResVehicle", HeaderText = "Vehicle", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "colResDates", HeaderText = "Dates", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "colResStatus", HeaderText = "Status", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "colResAmount", HeaderText = "Amount", Width = 100 }
            });

            // Setup Rentals DataGridView Columns
            dgvRentals.Columns.Clear();
            dgvRentals.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "colRentalId", HeaderText = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "colRentalVehicle", HeaderText = "Vehicle", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "colRentalDates", HeaderText = "Dates", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "colRentalStatus", HeaderText = "Status", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "colRentalAmount", HeaderText = "Amount", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "colRentalOdo", HeaderText = "Odometer", Width = 100 }
            });
        }

        private void WireEvents()
        {
            dgvReservations.SelectionChanged += OnRecordSelected;
            dgvRentals.SelectionChanged += OnRecordSelected;

            btnRefund.Click += OnRefundClick;
            btnCancel.Click += OnCancelClick;
            btnViewReceipt.Click += OnViewReceiptClick;
            btnPrint.Click += OnPrintClick;

            tabControlHistory.SelectedIndexChanged += OnTabChanged;
        }

        private void LoadSampleData()
        {
            // Sample reservations
            _reservations = new List<ReservationRecord>
            {
                new ReservationRecord
                {
                    Id = 1001,
                    CustomerName = "John Doe",
                    CustomerId = 123,
                    VehicleName = "Toyota Camry 2023",
                    VehicleId = 1,
                    StartDate = DateTime.Today.AddDays(-5),
                    EndDate = DateTime.Today.AddDays(-2),
                    Status = "Confirmed",
                    Amount = 5000.00m,
                    PaymentMethod = "GCash",
                    CreatedDate = DateTime.Today.AddDays(-7),
                    ImagePath = "vehicle1.jpg"
                },
                new ReservationRecord
                {
                    Id = 1002,
                    CustomerName = "Jane Smith",
                    CustomerId = 124,
                    VehicleName = "Honda Civic 2022",
                    VehicleId = 2,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(3),
                    Status = "Pending",
                    Amount = 4500.00m,
                    PaymentMethod = "Credit Card",
                    CreatedDate = DateTime.Today.AddDays(-1),
                    ImagePath = "vehicle2.jpg"
                }
            };

            // Sample rentals
            _rentals = new List<RentalRecord>
            {
                new RentalRecord
                {
                    Id = 2001,
                    CustomerName = "John Doe",
                    CustomerId = 123,
                    VehicleName = "Toyota Camry 2023",
                    VehicleId = 1,
                    StartDate = DateTime.Today.AddDays(-2),
                    EndDate = DateTime.Today.AddDays(2),
                    Status = "Active",
                    Amount = 7500.00m,
                    PaymentMethod = "GCash",
                    OdometerStart = 15430,
                    OdometerEnd = 15780,
                    CreatedDate = DateTime.Today.AddDays(-3),
                    ImagePath = "vehicle1.jpg"
                }
            };

            // Populate DataGridViews
            PopulateReservationsGrid();
            PopulateRentalsGrid();
        }

        private void PopulateReservationsGrid()
        {
            dgvReservations.Rows.Clear();

            foreach (var reservation in _reservations)
            {
                int rowIndex = dgvReservations.Rows.Add();
                var row = dgvReservations.Rows[rowIndex];

                row.Cells["colResId"].Value = reservation.Id;
                row.Cells["colResVehicle"].Value = reservation.VehicleName;
                row.Cells["colResDates"].Value = $"{reservation.StartDate:MMM dd} - {reservation.EndDate:MMM dd}";
                row.Cells["colResStatus"].Value = reservation.Status;
                row.Cells["colResAmount"].Value = $"₱{reservation.Amount:N0}";
                row.Tag = reservation;

                // Color status cell
                row.Cells["colResStatus"].Style.ForeColor = GetStatusColor(reservation.Status);
                row.Cells["colResAmount"].Style.ForeColor = _successColor;
            }
        }

        private void PopulateRentalsGrid()
        {
            dgvRentals.Rows.Clear();

            foreach (var rental in _rentals)
            {
                int rowIndex = dgvRentals.Rows.Add();
                var row = dgvRentals.Rows[rowIndex];

                row.Cells["colRentalId"].Value = rental.Id;
                row.Cells["colRentalVehicle"].Value = rental.VehicleName;
                row.Cells["colRentalDates"].Value = $"{rental.StartDate:MMM dd} - {rental.EndDate:MMM dd}";
                row.Cells["colRentalStatus"].Value = rental.Status;
                row.Cells["colRentalAmount"].Value = $"₱{rental.Amount:N0}";
                row.Cells["colRentalOdo"].Value = $"{rental.OdometerStart} - {rental.OdometerEnd} km";
                row.Tag = rental;

                // Color status cell
                row.Cells["colRentalStatus"].Style.ForeColor = GetStatusColor(rental.Status);
                row.Cells["colRentalAmount"].Style.ForeColor = _successColor;
            }
        }

        private void OnRecordSelected(object sender, EventArgs e)
        {
            if (tabControlHistory.SelectedTab == tabReservations && dgvReservations.SelectedRows.Count > 0)
            {
                _selectedRecord = dgvReservations.SelectedRows[0].Tag as ReservationRecord;
            }
            else if (tabControlHistory.SelectedTab == tabRentals && dgvRentals.SelectedRows.Count > 0)
            {
                _selectedRecord = dgvRentals.SelectedRows[0].Tag as RentalRecord;
            }
            else
            {
                ShowNoSelection();
                return;
            }

            ShowRecordDetails(_selectedRecord);
        }

        private void ShowRecordDetails(object record)
        {
            panelNoSelection.Visible = false;
            panelDetailsContent.Visible = true;

            if (record is ReservationRecord reservation)
            {
                lblDetailsTitle.Text = "📋 Reservation Details";
                lblReservationIdValue.Text = reservation.Id.ToString();
                lblVehicleName.Text = reservation.VehicleName;
                lblStatusValue.Text = reservation.Status;
                lblStatusValue.ForeColor = GetStatusColor(reservation.Status);
                lblDatesValue.Text = $"{reservation.StartDate:MMM dd} - {reservation.EndDate:MMM dd}, {reservation.StartDate:yyyy}";
                lblAmountValue.Text = $"₱{reservation.Amount:N2}";
                lblCustomerValue.Text = $"{reservation.CustomerName} (ID: {reservation.CustomerId})";
                lblPaymentValue.Text = $"{reservation.Status} - {reservation.PaymentMethod}";
                lblCreatedValue.Text = reservation.CreatedDate.ToString("yyyy-MM-dd");

                // Show/hide action buttons based on status
                btnCancel.Visible = reservation.Status == "Pending" || reservation.Status == "Confirmed";
                btnRefund.Visible = reservation.Status == "Confirmed" || reservation.Status == "Completed";
                btnViewReceipt.Visible = reservation.Status != "Pending";

                LoadVehicleImage(reservation.ImagePath);
            }
            else if (record is RentalRecord rental)
            {
                lblDetailsTitle.Text = "🚗 Rental Details";
                lblReservationIdValue.Text = rental.Id.ToString();
                lblVehicleName.Text = rental.VehicleName;
                lblStatusValue.Text = rental.Status;
                lblStatusValue.ForeColor = GetStatusColor(rental.Status);
                lblDatesValue.Text = $"{rental.StartDate:MMM dd} - {rental.EndDate:MMM dd}, {rental.StartDate:yyyy}";
                lblAmountValue.Text = $"₱{rental.Amount:N2}";
                lblCustomerValue.Text = $"{rental.CustomerName} (ID: {rental.CustomerId})";
                lblPaymentValue.Text = $"{rental.Status} - {rental.PaymentMethod}";
                lblCreatedValue.Text = rental.CreatedDate.ToString("yyyy-MM-dd");

                // Show/hide action buttons based on status
                btnCancel.Visible = rental.Status == "Active";
                btnRefund.Visible = rental.Status == "Completed";
                btnViewReceipt.Visible = true;

                LoadVehicleImage(rental.ImagePath);
            }
        }

        private void LoadVehicleImage(string imagePath)
        {
            try
            {
                picVehicle.Image = null;

                var fullPath = Path.Combine(
                    AppContext.BaseDirectory,
                    "Storage",
                    imagePath);

                if (!File.Exists(fullPath))
                {
                    ShowPlaceholderImage();
                    return;
                }

                using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                using var temp = Image.FromStream(fs);
                picVehicle.Image = new Bitmap(temp);
            }
            catch
            {
                ShowPlaceholderImage();
            }
        }

        private void ShowPlaceholderImage()
        {
            try
            {
                var path = Path.Combine(
                    AppContext.BaseDirectory,
                    "Assets",
                    "img_placeholder.png");

                if (!File.Exists(path))
                {
                    picVehicle.Image = null;
                    return;
                }

                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                using var temp = Image.FromStream(fs);
                picVehicle.Image = new Bitmap(temp);
            }
            catch
            {
                picVehicle.Image = null;
            }
        }

        private void ShowNoSelection()
        {
            panelDetailsContent.Visible = false;
            panelNoSelection.Visible = true;
            _selectedRecord = null;
        }

        private Color GetStatusColor(string status)
        {
            return status.ToLower() switch
            {
                "confirmed" or "completed" or "paid" => _successColor,
                "active" => _infoColor,
                "pending" => _warningColor,
                "cancelled" or "refunded" => _dangerColor,
                _ => _mutedColor
            };
        }

        private void OnRefundClick(object sender, EventArgs e)
        {
            if (_selectedRecord == null)
            {
                ShowNotification("Please select a record first.", ToolTipIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to process a refund for this transaction?",
                "Confirm Refund",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Process refund logic here
                ShowNotification("Refund processed successfully.", ToolTipIcon.Info);

                // Refresh data
                LoadSampleData();
                ShowNoSelection();
                UpdateSummary();
            }
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            if (_selectedRecord == null)
            {
                ShowNotification("Please select a record first.", ToolTipIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to cancel this reservation/rental?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Process cancellation logic here
                ShowNotification("Cancellation processed successfully.", ToolTipIcon.Info);

                // Refresh data
                LoadSampleData();
                ShowNoSelection();
                UpdateSummary();
            }
        }

        private void OnViewReceiptClick(object sender, EventArgs e)
        {
            if (_selectedRecord == null)
            {
                ShowNotification("Please select a record first.", ToolTipIcon.Warning);
                return;
            }

            ShowNotification("Opening receipt viewer...", ToolTipIcon.Info);
            // Implement receipt viewing logic
        }

        private void OnPrintClick(object sender, EventArgs e)
        {
            if (_selectedRecord == null)
            {
                ShowNotification("Please select a record first.", ToolTipIcon.Warning);
                return;
            }

            ShowNotification("Printing record details...", ToolTipIcon.Info);
            // Implement printing logic
        }

        private void OnTabChanged(object sender, EventArgs e)
        {
            ShowNoSelection();
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int totalReservations = _reservations.Count;
            int totalRentals = _rentals.Count;

            lblSummary.Text = $"Total: {totalReservations} reservations | {totalRentals} rentals";
        }

        private void ShowNotification(string message, ToolTipIcon icon)
        {
            var notification = new ToolTip
            {
                ToolTipTitle = "Notification",
                ToolTipIcon = icon,
                IsBalloon = true,
                InitialDelay = 0,
                ShowAlways = false
            };

            notification.Show(message, this, Width - 300, Height - 100, 3000);
        }
    }

    // Data Classes
    internal class ReservationRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public string VehicleName { get; set; } = string.Empty;
        public int VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }

    internal class RentalRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public string VehicleName { get; set; } = string.Empty;
        public int VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public int OdometerStart { get; set; }
        public int OdometerEnd { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}