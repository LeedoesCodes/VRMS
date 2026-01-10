using System.Data;
using VRMS.Database;
using VRMS.Models.Billing;

namespace VRMS.Repositories.Billing;

public class RateConfigurationRepository
{
    // ----------------------------
    // CREATE
    // ----------------------------

    public int Create(
        int vehicleCategoryId,
        decimal daily,
        decimal weekly,
        decimal monthly,
        decimal hourly)
    {
        var table = DB.Query(
            "CALL sp_rate_configurations_create(@cat,@daily,@weekly,@monthly,@hourly);",
            ("@cat", vehicleCategoryId),
            ("@daily", daily),
            ("@weekly", weekly),
            ("@monthly", monthly),
            ("@hourly", hourly)
        );

        return Convert.ToInt32(
            table.Rows[0]["rate_configuration_id"]);
    }

    // ----------------------------
    // READ
    // ----------------------------

    public RateConfiguration GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_rate_configurations_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Rate configuration not found.");

        return Map(table.Rows[0]);
    }

    public RateConfiguration GetByCategory(int categoryId)
    {
        var table = DB.Query(
            "CALL sp_rate_configurations_get_by_category(@cat);",
            ("@cat", categoryId)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Rate configuration not found for category.");

        return Map(table.Rows[0]);
    }

    // ----------------------------
    // UPDATE
    // ----------------------------

    public void Update(
        int id,
        decimal daily,
        decimal weekly,
        decimal monthly,
        decimal hourly)
    {
        DB.Execute(
            "CALL sp_rate_configurations_update(@id,@daily,@weekly,@monthly,@hourly);",
            ("@id", id),
            ("@daily", daily),
            ("@weekly", weekly),
            ("@monthly", monthly),
            ("@hourly", hourly)
        );
    }

    // ----------------------------
    // DELETE
    // ----------------------------

    public void Delete(int id)
    {
        DB.Execute(
            "CALL sp_rate_configurations_delete(@id);",
            ("@id", id)
        );
    }

    // ----------------------------
    // MAPPING
    // ----------------------------

    private static RateConfiguration Map(DataRow row)
    {
        return new RateConfiguration
        {
            Id = Convert.ToInt32(row["id"]),
            VehicleCategoryId =
                Convert.ToInt32(row["vehicle_category_id"]),
            DailyRate = Convert.ToDecimal(row["daily_rate"]),
            WeeklyRate = Convert.ToDecimal(row["weekly_rate"]),
            MonthlyRate = Convert.ToDecimal(row["monthly_rate"]),
            HourlyRate = Convert.ToDecimal(row["hourly_rate"])
        };
    }
}
