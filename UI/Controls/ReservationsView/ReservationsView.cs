using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VRMS.DTOs.Reservation;
using VRMS.Enums;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;
using VRMS.UI.ApplicationService;
using VRMS.UI.Forms.Payments;
using VRMS.UI.Forms.Reservation;

namespace VRMS.Controls
{
    public partial class ReservationsView : UserControl
    {
        private readonly CustomerService _customerService;
        private readonly VehicleService _vehicleService;
        private readonly ReservationService _reservationService;
        private readonly RentalService _rentalService;

        private List<ReservationGridRow> _allRows = new();

        private static readonly string PlaceholderImagePath =
            Path.Combine("Assets", "img_placeholder.png");

        public ReservationsView()
        {
            InitializeComponent();

            _customerService = ApplicationServices.CustomerService;
            _vehicleService = ApplicationServices.VehicleService;
            _reservationService = ApplicationServices.ReservationService;
            _rentalService = ApplicationServices.RentalService;

            Load += ReservationsView_Load;
            dgvReservations.SelectionChanged += DgvReservations_SelectionChanged;
            txtSearch.TextChanged += (_, __) => ApplyFilters();
            cbStatusFilter.SelectedIndexChanged += (_, __) => ApplyFilters();
        }


        // =====================================================
        // LOAD
        // =====================================================

        private void ReservationsView_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadStatusFilter();
            LoadReservations();
        }

        // =====================================================
        // GRID SETUP
        // =====================================================

        private void ConfigureGrid()
        {
            dgvReservations.AutoGenerateColumns = false;
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;
            dgvReservations.Columns.Clear();

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ReservationId",
                Width = 70
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer",
                DataPropertyName = "CustomerName",
                Width = 200
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Vehicle",
                DataPropertyName = "VehicleName",
                Width = 220
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Start",
                DataPropertyName = "StartDate",
                DefaultCellStyle = { Format = "MMM dd, yyyy" },
                Width = 120
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "End",
                DataPropertyName = "EndDate",
                DefaultCellStyle = { Format = "MMM dd, yyyy" },
                Width = 120
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 100
            });

            dgvReservations.CellFormatting += DgvReservations_CellFormatting;
        }

        private void LoadStatusFilter()
        {
            cbStatusFilter.Items.Clear();
            cbStatusFilter.Items.Add("All");

            foreach (var s in Enum.GetValues(typeof(ReservationStatus)))
                cbStatusFilter.Items.Add(s);

            cbStatusFilter.SelectedIndex = 0;
        }

        private void LoadReservations()
        {
            _allRows = _reservationService.GetAllForGrid();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            IEnumerable<ReservationGridRow> filtered = _allRows;

            if (cbStatusFilter.SelectedIndex > 0)
            {
                var status = (ReservationStatus)cbStatusFilter.SelectedItem;
                filtered = filtered.Where(r => r.Status == status);
            }

            dgvReservations.DataSource = filtered.ToList();
            UpdateActionButtons();
        }

        // =====================================================
        // GRID STYLING
        // =====================================================

        private void DgvReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReservations.Columns[e.ColumnIndex].DataPropertyName != "Status")
                return;

            if (e.Value is not ReservationStatus status)
                return;

            e.CellStyle.Font = new Font(dgvReservations.Font, FontStyle.Bold);
            e.CellStyle.ForeColor = status switch
            {
                ReservationStatus.Pending => Color.Orange,
                ReservationStatus.Confirmed => Color.Green,
                ReservationStatus.Cancelled => Color.DarkGray,
                _ => e.CellStyle.ForeColor
            };
        }

        // =====================================================
        // SELECTION
        // =====================================================

        private void DgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            UpdateActionButtons();

            if (dgvReservations.SelectedRows.Count == 0)
                return;

            if (dgvReservations.SelectedRows[0].DataBoundItem is not ReservationGridRow row)
                return;

            var reservation = _reservationService.GetReservationById(row.ReservationId);
            var vehicle = _vehicleService.GetVehicleById(reservation.VehicleId);
            var customer = _customerService.GetCustomerById(reservation.CustomerId);

            lblDetailVehicle.Text = $"{vehicle.Year} {vehicle.Make} {vehicle.Model}";
            lblDetailCustomer.Text = $"{customer.FirstName} {customer.LastName}";
            lblDetailDates.Text = $"From {reservation.StartDate:d} to {reservation.EndDate:d}";
            lblDetailAmount.Text = "Price: ₱ --";

            LoadVehicleImage(vehicle.Id);
        }

        private void LoadVehicleImage(int vehicleId)
        {
            if (pbVehicle.Image != null)
            {
                pbVehicle.Image.Dispose();
                pbVehicle.Image = null;
            }

            var images = _vehicleService.GetVehicleImages(vehicleId);

            string imagePath = images.Count > 0
                ? Path.Combine(AppContext.BaseDirectory, "Storage", images[0].ImagePath)
                : Path.Combine(AppContext.BaseDirectory, PlaceholderImagePath);

            if (!File.Exists(imagePath))
                return;

            using var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            pbVehicle.Image = Image.FromStream(fs);
        }

        // =====================================================
        // ACTION BUTTONS
        // =====================================================

        private void UpdateActionButtons()
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                btnCancelReservation.Enabled = false;
                btnProceedRent.Enabled = false;
               
                btnConfirmReservation.Enabled = false;
                return;
            }

            var row = dgvReservations.SelectedRows[0].DataBoundItem as ReservationGridRow;
            if (row == null) return;

           

            btnCancelReservation.Enabled =
                row.Status == ReservationStatus.Pending ||
                row.Status == ReservationStatus.Confirmed;

            btnConfirmReservation.Enabled =
                row.Status == ReservationStatus.Pending;

            btnProceedRent.Enabled =
                row.Status == ReservationStatus.Confirmed;
        }

        // =====================================================
        // CANCEL
        // =====================================================

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
                return;

            if (dgvReservations.SelectedRows[0].DataBoundItem is not ReservationGridRow row)
                return;

            if (MessageBox.Show(
                    "Cancel this reservation?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            _reservationService.CancelReservation(row.ReservationId);
            LoadReservations();
        }

        // =====================================================
        // CONFIRM RESERVATION
        // =====================================================

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
                return;

            if (dgvReservations.SelectedRows[0].DataBoundItem is not ReservationGridRow row)
                return;

            if (row.Status != ReservationStatus.Pending)
            {
                MessageBox.Show(
                    "Only pending reservations can be confirmed.",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reservation = _reservationService.GetReservationById(row.ReservationId);
                var vehicle = _vehicleService.GetVehicleById(reservation.VehicleId);
                var customer = _customerService.GetCustomerById(reservation.CustomerId);

                var estimatedTotal =
                    ApplicationServices.RateService.CalculateRentalCost(
                        reservation.StartDate,
                        reservation.EndDate,
                        vehicle.VehicleCategoryId);

                using var feeForm = new ReservationFee();

                feeForm.SetReservationDetails(
                    $"{customer.FirstName} {customer.LastName}",
                    $"{vehicle.Make} {vehicle.Model}",
                    reservation.Id.ToString(),
                    estimatedTotal,
                    reservation.ReservationFeeAmount
                );

                if (feeForm.ShowDialog(this) != DialogResult.OK)
                    return;

                _reservationService.ConfirmReservation(reservation.Id);
                MessageBox.Show("Reservation confirmed.", "Success");

                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // =====================================================
        // PROCEED TO RENT
        // =====================================================

        private void btnProceedRent_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
                return;

            if (dgvReservations.SelectedRows[0].DataBoundItem is not ReservationGridRow row)
                return;

            if (row.Status != ReservationStatus.Confirmed)
            {
                MessageBox.Show(
                    "Reservation must be confirmed before renting.",
                    "Not Allowed");
                return;
            }

            var reservation = _reservationService.GetReservationById(row.ReservationId);
            var vehicle = _vehicleService.GetVehicleById(reservation.VehicleId);
            var customer = _customerService.GetCustomerById(reservation.CustomerId);

            using var form = new VRMS.UI.Forms.Rentals.ProceedToRent(
                $"{customer.FirstName} {customer.LastName}",
                $"{vehicle.Year} {vehicle.Make} {vehicle.Model}",
                vehicle.Odometer
            );

            if (form.ShowDialog(this) == DialogResult.OK)
                LoadReservations();
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            using var form = new AddReservationForm();
            if (form.ShowDialog(FindForm()) == DialogResult.OK)
                LoadReservations();
        }
    }
}
