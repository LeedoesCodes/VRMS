using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Add your validation and SQL saving logic here

            // If save is successful:
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}