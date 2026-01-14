using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VRMS.Models.Dashboard;
using VRMS.Services.Dashboard;
using VRMS.UI.Config.ApplicationService;

namespace VRMS.Controls
{
    public partial class DashboardView : UserControl
    {
        private readonly DashboardService _dashboardService;

        public DashboardView()
        {
            InitializeComponent();

            _dashboardService = ApplicationServices.DashboardService;

            // Date picker = END MONTH selector
            dateRangePicker.Value =
                new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1
                );

            this.Load += (s, e) => LoadDashboard();
            btnRefresh.Click += (s, e) => LoadDashboard();
            dateRangePicker.ValueChanged += (s, e) => LoadDashboard();
        }

        // =====================================================
        // MAIN LOAD
        // =====================================================

        private void LoadDashboard()
        {
            DashboardSnapshot snapshot;

            try
            {
                snapshot =
                    _dashboardService.GetSnapshot(
                        dateRangePicker.Value.Year,
                        dateRangePicker.Value.Month
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // -----------------------------
            // FLEET CARDS
            // -----------------------------

            lblTotalValue.Text =
                snapshot.Fleet.TotalVehicles.ToString();

            lblAvailableValue.Text =
                snapshot.Fleet.AvailableVehicles.ToString();

            lblMaintenanceValue.Text =
                snapshot.Fleet.UnderMaintenanceVehicles.ToString();

            // -----------------------------
            // RENTAL CARDS
            // -----------------------------

            lblRentedValue.Text =
                snapshot.Rentals.ActiveRentals.ToString();

            lblOverdueValue.Text =
                snapshot.Rentals.OverdueRentals.ToString();

            // -----------------------------
            // REVENUE CARD
            // -----------------------------

            lblRevenueValue.Text =
                $"₱{snapshot.Revenue.MonthlyRevenue:N0}";

            // -----------------------------
            // CHART (FIXED)
            // -----------------------------

            SetupPerformanceChart(snapshot.MonthlyTrends);

            // -----------------------------
            // GRIDS
            // -----------------------------

            PopulateGrids();
        }

        // =====================================================
        // CHART (DATE-BASED — REAL FIX)
        // =====================================================

        private void SetupPerformanceChart(
            IReadOnlyList<DashboardMonthlyTrend> trends)
        {
            // Remove old charts
            foreach (Control c in pnlChartArea.Controls)
            {
                if (c is Chart oldChart)
                    oldChart.Dispose();
            }

            pnlChartArea.Controls.Clear();
            pnlChartArea.Controls.Add(lblChartTitle);

            Chart chart = new Chart { Dock = DockStyle.Fill };

            ChartArea area = new ChartArea("Main");

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(240, 240, 240);

            // 🔥 KEY FIX
            area.AxisX.IntervalType = DateTimeIntervalType.Months;
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Format = "MMM yy";
            area.AxisX.IsMarginVisible = true;
            area.AxisX.ScaleView.Zoomable = false;
            area.AxisX.ScrollBar.Enabled = false;

            chart.ChartAreas.Add(area);

            Series series = new Series("Rentals Completed")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
                Color = Color.FromArgb(52, 152, 219),
                ToolTip = "#VAL rentals in #AXISLABEL"
            };

            series["PointWidth"] = "0.7";
            series.Points.Clear();

            foreach (var item in trends)
            {
                DateTime month =
                    new DateTime(item.Year, item.Month, 1);

                int index =
                    series.Points.AddXY(
                        month,
                        item.CompletedRentals
                    );

                // Highlight selected month
                if (item.Year == dateRangePicker.Value.Year &&
                    item.Month == dateRangePicker.Value.Month)
                {
                    series.Points[index].Color =
                        Color.FromArgb(39, 174, 96);
                }
            }

            chart.Series.Add(series);
            chart.Legends.Add(
                new Legend { Docking = Docking.Bottom });

            pnlChartArea.Controls.Add(chart);
            chart.BringToFront();
            lblChartTitle.BringToFront();
        }

        // =====================================================
        // GRIDS
        // =====================================================

        private void PopulateGrids()
        {
            dgvTodaySchedule.DataSource =
                _dashboardService.GetTodaySchedule();

            dgvAlerts.DataSource =
                _dashboardService.GetAlerts();

            dgvAlerts.DataBindingComplete += (s, e) =>
            {
                foreach (DataGridViewRow row in dgvAlerts.Rows)
                {
                    string priority =
                        row.Cells["priority"].Value?.ToString();

                    if (priority == "CRITICAL")
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    else if (priority == "HIGH")
                        row.DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
            };
        }
    }
}
