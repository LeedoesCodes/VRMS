using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Forms
{
    // The ": Form" part is CRITICAL. Without it, you get the errors you are seeing.
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // This method handles the Load event safely
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}