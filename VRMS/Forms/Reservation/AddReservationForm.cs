using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();

            // Wire up internal events manually if desired, 
            // or use the Designer to double-click buttons later.
            this.btnCancel.Click += (s, e) => this.Close();
        }

        // Logic Placeholders
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Database save logic goes here
        }

        private void RecalculateTotal(object sender, EventArgs e)
        {
            // Calculation logic goes here
        }
    }
}