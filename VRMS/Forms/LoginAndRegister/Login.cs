using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Add rounded corners to the card panel (optional logic)
            // Or just keep the flat look
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Add placeholders for other clicks or link them in Designer
        // private void btnLogin_Click(object sender, EventArgs e) { ... }
        // private void btnGoToRegister_Click(object sender, EventArgs e) { ... }
    }
}