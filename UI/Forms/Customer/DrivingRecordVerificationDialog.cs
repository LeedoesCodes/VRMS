using System;
using System.Windows.Forms;

namespace VRMS.UI.Forms.Customer
{
    public partial class DrivingRecordVerificationDialog : Form
    {
        // Optional: expose the result in a readable way
        public bool? IsCleared { get; private set; }

        public DrivingRecordVerificationDialog()
        {
            InitializeComponent();
            WireEvents();
        }

        // --------------------------------------------------
        // EVENT WIRING
        // --------------------------------------------------

        private void WireEvents()
        {
            btnCleared.Click += BtnCleared_Click;
            btnNotCleared.Click += BtnNotCleared_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        // --------------------------------------------------
        // BUTTON LOGIC
        // --------------------------------------------------

        private void BtnCleared_Click(object? sender, EventArgs e)
        {
            IsCleared = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnNotCleared_Click(object? sender, EventArgs e)
        {
            IsCleared = false;
            DialogResult = DialogResult.No;
            Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            IsCleared = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
