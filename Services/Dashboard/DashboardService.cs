using System.Data;
using VRMS.Models.Dashboard;
using VRMS.Repositories.Dashboard;

namespace VRMS.Services.Dashboard
{
    public class DashboardService
    {
        private readonly DashboardRepository _repo;

        public DashboardService(DashboardRepository repo)
        {
            _repo = repo;
        }

        // =====================================================
        // MAIN ENTRY POINT (UI CALLS THIS ONLY)
        // =====================================================

        /// <summary>
        /// Retrieves a complete dashboard snapshot.
        /// Chart shows the last 10 months ending at the selected month.
        /// Cards reflect the selected month.
        /// </summary>
        public DashboardSnapshot GetSnapshot(
            int year,
            int month)
        {
            // -----------------------------
            // DATE CONTEXT
            // -----------------------------

            int selectedYear = year;
            int selectedMonth = month;

            // Chart: last 10 months (inclusive)
            var (startYear, startMonth) =
                GetMonthOffset(
                    selectedYear,
                    selectedMonth,
                    -9);

            // -----------------------------
            // DATA FETCH
            // -----------------------------

            var fleetStats =
                _repo.GetFleetStats();

            var rentalStats =
                _repo.GetRentalStats();

            var revenueStats =
                _repo.GetMonthlyRevenue(
                    selectedYear,
                    selectedMonth);

            // Raw data from DB (may skip months!)
            var rawTrends =
                _repo.GetMonthlyCompletedRentals(
                    startYear,
                    startMonth,
                    selectedYear,
                    selectedMonth);

            // Normalize months (VERY IMPORTANT)
            var monthlyTrends =
                NormalizeMonthlyTrends(
                    rawTrends,
                    startYear,
                    startMonth,
                    selectedYear,
                    selectedMonth);

            // -----------------------------
            // SNAPSHOT ASSEMBLY
            // -----------------------------

            return new DashboardSnapshot
            {
                Fleet = fleetStats,
                Rentals = rentalStats,
                Revenue = revenueStats,
                MonthlyTrends = monthlyTrends
            };
        }

        // =====================================================
        // INTERNAL HELPERS
        // =====================================================

        /// <summary>
        /// Offsets a year/month pair by N months.
        /// Example: (2025, 1) + (-1) → (2024, 12)
        /// </summary>
        private static (int year, int month)
            GetMonthOffset(
                int year,
                int month,
                int offset)
        {
            int totalMonths =
                (year * 12 + (month - 1)) + offset;

            int newYear =
                totalMonths / 12;

            int newMonth =
                (totalMonths % 12) + 1;

            return (newYear, newMonth);
        }

        /// <summary>
        /// Ensures a continuous month series.
        /// Missing months are filled with zero values.
        /// This guarantees the chart always shows multiple months.
        /// </summary>
        private static IReadOnlyList<DashboardMonthlyTrend>
            NormalizeMonthlyTrends(
                IReadOnlyList<DashboardMonthlyTrend> raw,
                int startYear,
                int startMonth,
                int endYear,
                int endMonth)
        {
            // Map existing data for fast lookup
            var map = raw.ToDictionary(
                x => (x.Year, x.Month),
                x => x.CompletedRentals
            );

            var result = new List<DashboardMonthlyTrend>();

            var current =
                new DateTime(startYear, startMonth, 1);

            var end =
                new DateTime(endYear, endMonth, 1);

            while (current <= end)
            {
                map.TryGetValue(
                    (current.Year, current.Month),
                    out int completed);

                result.Add(new DashboardMonthlyTrend
                {
                    Year = current.Year,
                    Month = current.Month,
                    CompletedRentals = completed // 0 if missing
                });

                current = current.AddMonths(1);
            }

            return result;
        }

        // =====================================================
        // TODAY'S SCHEDULE
        // =====================================================

        public DataTable GetTodaySchedule()
        {
            return _repo.GetTodaySchedule();
        }

        // =====================================================
        // ALERTS
        // =====================================================

        public DataTable GetAlerts()
        {
            return _repo.GetAlerts();
        }
    }
}
