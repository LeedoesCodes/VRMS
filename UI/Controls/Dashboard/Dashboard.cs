using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VRMS.Controls
{
    public partial class DashboardView : System.Windows.Forms.UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadDashboard();
            btnRefresh.Click += (s, e) => LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Update Cards
            lblTotalValue.Text = "58";
            lblAvailableValue.Text = "14";
            lblRentedValue.Text = "32";
            lblRevenueValue.Text = "₱245.8k";
            lblOverdueValue.Text = "5";
            lblMaintenanceValue.Text = "7";

            PopulateGrids();
            SetupPerformanceChart();
        }

        private void PopulateGrids()
        {
            // 1. Today's Schedule - Expanded
            DataTable dtSchedule = new DataTable();
            dtSchedule.Columns.Add("Type");
            dtSchedule.Columns.Add("Vehicle");
            dtSchedule.Columns.Add("Customer");
            dtSchedule.Columns.Add("Status");

            dtSchedule.Rows.Add("🔑 Pickup", "Toyota Vios (GAS-123)", "John Doe", "Confirmed");
            dtSchedule.Rows.Add("📩 Return", "Honda Civic (ABC-888)", "Jane Smith", "Pending");
            dtSchedule.Rows.Add("🔑 Pickup", "Ford Ranger (WLD-4x4)", "Mike Ross", "Ready");
            dtSchedule.Rows.Add("📩 Return", "Mitsubishi Mirage", "Sarah Lee", "In-Transit");
            dtSchedule.Rows.Add("🔑 Pickup", "Suzuki Ertiga", "Robert Fox", "Processing");
            dtSchedule.Rows.Add("📩 Return", "Hyundai Tucson", "Emma Wilson", "Delayed");
            dtSchedule.Rows.Add("🔑 Pickup", "Nissan Almera", "Chris Pratt", "Confirmed");

            dgvTodaySchedule.DataSource = dtSchedule;

            // 2. Alerts - Expanded with Priority
            DataTable dtAlerts = new DataTable();
            dtAlerts.Columns.Add("Priority");
            dtAlerts.Columns.Add("Issue Description");
            dtAlerts.Columns.Add("Deadline");

            dtAlerts.Rows.Add("CRITICAL", "Overdue: Toyota Fortuner (VBN-456)", "3 Days Late");
            dtAlerts.Rows.Add("HIGH", "Maintenance: Oil Change (Hyundai Accent)", "Today");
            dtAlerts.Rows.Add("CRITICAL", "Overdue: Nissan NV350 (UVW-901)", "1 Day Late");
            dtAlerts.Rows.Add("MEDIUM", "Insurance Expiring: Mitsubishi Xpander", "In 5 Days");
            dtAlerts.Rows.Add("HIGH", "Brake Check Required: Ford Everest", "Tomorrow");
            dtAlerts.Rows.Add("LOW", "Cleanliness Alert: Toyota Raize", "Routine");

            dgvAlerts.DataSource = dtAlerts;

            // Apply formatting to Alerts Grid
            dgvAlerts.DataBindingComplete += (s, e) => {
                foreach (DataGridViewRow row in dgvAlerts.Rows)
                {
                    string priority = row.Cells["Priority"].Value?.ToString();
                    if (priority == "CRITICAL") row.DefaultCellStyle.ForeColor = Color.Red;
                    if (priority == "HIGH") row.DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
            };
        }

        private void SetupPerformanceChart()
        {
            pnlChartArea.Controls.Clear();
            pnlChartArea.Controls.Add(lblChartTitle);

            Chart chart = new Chart { Dock = DockStyle.Fill };

            // 1. Force the Chart Area to expand
            ChartArea area = new ChartArea("Main");
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);

            // Ensure all labels show up
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Enabled = true;

            chart.ChartAreas.Add(area);

            // 2. Configure the Series with explicit Bar Width
            Series s = new Series("Rentals Completed")
            {
                ChartType = SeriesChartType.Column, // Using Column for clearer bars
                XValueType = ChartValueType.String,
                Color = Color.FromArgb(52, 152, 219),
            };

            // Explicitly set the bar width (0.8 is a good standard size)
            s["PointWidth"] = "0.8";

            string[] months = { "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", "Jan" };
            int[] data = { 38, 42, 55, 68, 50, 62, 45, 80, 110, 75 };

            // 3. Clear existing points before adding new ones
            s.Points.Clear();
            for (int i = 0; i < months.Length; i++)
            {
                int pointIndex = s.Points.AddXY(months[i], data[i]);
                // This ensures each bar is treated as a distinct data point
                s.Points[pointIndex].AxisLabel = months[i];
            }

            chart.Series.Add(s);

            // 4. Position the Legend at the bottom
            Legend leg = new Legend("Legend") { Docking = Docking.Bottom };
            chart.Legends.Add(leg);

            pnlChartArea.Controls.Add(chart);
            chart.BringToFront();
            lblChartTitle.BringToFront();
        }
    }
}