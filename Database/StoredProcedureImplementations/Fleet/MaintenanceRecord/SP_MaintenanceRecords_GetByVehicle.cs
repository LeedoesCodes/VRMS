namespace VRMS.Database.StoredProcedureImplementations.Fleet.MaintenanceRecord;

public static class SP_MaintenanceRecords_GetByVehicle
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_maintenance_records_get_by_vehicle;

                                  CREATE PROCEDURE sp_maintenance_records_get_by_vehicle (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          vehicle_id,
                                          description,
                                          cost,
                                          start_date,
                                          end_date
                                      FROM maintenance_records
                                      WHERE vehicle_id = p_vehicle_id
                                      ORDER BY start_date DESC;
                                  END;
                                  """;
}