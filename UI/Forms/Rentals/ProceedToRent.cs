using System;
using System.Windows.Forms;
using VRMS.Enums;

namespace VRMS.UI.Forms.Rentals
{
    public partial class ProceedToRent : Form
    {
        // =========================
        // CONTEXT (TEMP / UI ONLY)
        // =========================
        private readonly string _customerName;
        private readonly string _vehicleInfo;
        private readonly int _currentOdometer;

        // =========================
        // CONSTRUCTOR
        // =========================
        public ProceedToRent(
            string customerName,
            string vehicleInfo,
            int currentOdometer)
        {
            InitializeComponent();

            _customerName = customerName;
            _vehicleInfo = vehicleInfo;
            _currentOdometer = currentOdometer;

            Load += ProceedToRent_Load;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
        }

        // =========================
        // LOAD
        // =========================
        private void ProceedToRent_Load(object? sender, EventArgs e)
        {
            // Customer / Vehicle display
            lblCustomerDetails.Text = _customerName;
            lblVehicleDetails.Text = _vehicleInfo;

            // Dates
            dtPickup.Value = DateTime.Now;
            dtReturn.Value = DateTime.Now.AddDays(1);

            // Odometer
            txtOdometer.Text = _currentOdometer.ToString("N0");

            // Fuel
            cbFuel.SelectedIndex = (int)FuelLevel.Full;

            // Total (preview only)
            lblTotal.Text = "Total: ₱0.00";
        }

        // =========================
        // CONFIRM RENTAL
        // =========================
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Basic validation only (UI-level)
            if (dtReturn.Value <= dtPickup.Value)
            {
                MessageBox.Show(
                    "Return date must be after pickup date.",
                    "Invalid Dates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cbFuel.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select fuel level.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // TEMP SUCCESS (real rental logic will come later)
            MessageBox.Show(
                "Rental confirmed successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
