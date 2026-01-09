using System;
using System.Windows.Forms;

namespace VRMS.Controls
{
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
            SetupGrids();
        }

        private void SetupGrids()
        {
            
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvLogs.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        }

        
        private void btnAddUser_Click(object sender, EventArgs e) { }
        private void btnEditUser_Click(object sender, EventArgs e) { }
        private void btnDeleteUser_Click(object sender, EventArgs e) { }
        private void btnClearLogs_Click(object sender, EventArgs e) { }
        private void btnSaveSettings_Click(object sender, EventArgs e) { }
    }
}