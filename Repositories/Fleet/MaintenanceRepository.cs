using System.Data;
using VRMS.Database;
using VRMS.Models.Fleet;

namespace VRMS.Repositories.Fleet;

public class MaintenanceRepository
{
    public int Create(
        int vehicleId,
        string description,
        decimal cost,
        DateTime start)
    {
        var table = DB.Query(
            "CALL sp_maintenance_records_create(@vid,@desc,@cost,@start);",
            ("@vid", vehicleId),
            ("@desc", description),
            ("@cost", cost),
            ("@start", start)
        );

        return Convert.ToInt32(table.Rows[0]["maintenance_record_id"]);
    }

    public void Close(int id, DateTime end)
    {
        DB.Execute(
            "CALL sp_maintenance_records_close(@id,@end);",
            ("@id", id),
            ("@end", end)
        );
    }

    public MaintenanceRecord GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_maintenance_records_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Maintenance record not found.");

        return Map(table.Rows[0]);
    }

    public List<MaintenanceRecord> GetByVehicle(int vehicleId)
    {
        var table = DB.Query(
            "CALL sp_maintenance_records_get_by_vehicle(@id);",
            ("@id", vehicleId)
        );

        var list = new List<MaintenanceRecord>();
        foreach (DataRow r in table.Rows)
            list.Add(Map(r));

        return list;
    }

    private static MaintenanceRecord Map(DataRow r) => new()
    {
        Id = Convert.ToInt32(r["id"]),
        VehicleId = Convert.ToInt32(r["vehicle_id"]),
        Description = r["description"].ToString()!,
        Cost = Convert.ToDecimal(r["cost"]),
        StartDate = Convert.ToDateTime(r["start_date"]),
        EndDate = r["end_date"] == DBNull.Value
            ? null
            : Convert.ToDateTime(r["end_date"])
    };
}