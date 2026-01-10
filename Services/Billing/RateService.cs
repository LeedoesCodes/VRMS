using VRMS.Models.Billing;

namespace VRMS.Services.Billing;

public class RateService
{
    public decimal CalculateRentalCost(
        DateTime pickup,
        DateTime returnDate,
        RateConfiguration rate)
    {
        if (returnDate < pickup)
            throw new InvalidOperationException(
                "Return date cannot be before pickup date.");

        return CalculateCheapest(
            pickup,
            returnDate,
            rate);
    }

    // ------------------------------------
    // PRICING RULES
    // ------------------------------------

    private static decimal CalculateCheapest(
        DateTime start,
        DateTime end,
        RateConfiguration rate)
    {
        var hours =
            (decimal)(end - start).TotalHours;

        if (hours <= 0)
            return 0m;

        hours = Math.Ceiling(hours);

        var days = Math.Ceiling(hours / 24m);
        var weeks = Math.Floor(days / 7m);
        var months = Math.Floor(days / 30m);

        decimal best = decimal.MaxValue;

        best = Math.Min(best,
            hours * rate.HourlyRate);

        best = Math.Min(best,
            days * rate.DailyRate);

        best = Math.Min(best,
            weeks * rate.WeeklyRate +
            (days % 7m) * rate.DailyRate);

        best = Math.Min(best,
            months * rate.MonthlyRate +
            Math.Floor((days % 30m) / 7m)
            * rate.WeeklyRate +
            ((days % 30m) % 7m)
            * rate.DailyRate);

        return decimal.Round(best, 2);
    }
}