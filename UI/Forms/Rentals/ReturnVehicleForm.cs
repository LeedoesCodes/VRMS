using System;
using System.Windows.Forms;
using VRMS.Services.Rental;

namespace VRMS.Forms
{
    public partial class ReturnVehicleForm : Form
    {
        private readonly int _rentalId;
        private readonly RentalService _rentalService;

        public ReturnVehicleForm(
            int rentalId,
            RentalService rentalService)
        {
            InitializeComponent();

            _rentalId = rentalId;
            _rentalService = rentalService;
        }

        // Logic placeholders
        private void btnConfirm_Click(object sender, EventArgs e) { }
        private void btnCancel_Click(object sender, EventArgs e) { }
        private void BtnAddDamage_Click(object sender, EventArgs e) { }
    }
}