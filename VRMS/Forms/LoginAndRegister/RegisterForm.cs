using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Link these in the designer or through the constructor
        private void btnRegister_Click(object sender, EventArgs e) { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Login
        }
    }
}