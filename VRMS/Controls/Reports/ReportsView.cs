using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Controls
{
    public partial class ReportsView : UserControl
    {
        public ReportsView()
        {
            InitializeComponent();
            SetupDesign();
        }

        private void SetupDesign()
        {
            // Consistent styling for the report grid
            dgvReportData.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvReportData.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dgvReportData.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvReportData.EnableHeadersVisualStyles = false;
        }

        // Placeholders for Export and Filter logic
        private void btnApplyFilter_Click(object sender, EventArgs e) { }
        private void btnExportExcel_Click(object sender, EventArgs e) { }
        private void btnExportPDF_Click(object sender, EventArgs e) { }
    }
}