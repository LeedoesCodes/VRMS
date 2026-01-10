namespace VRMS.Database.StoredProcedureImplementations.Fleet.MaintenanceRecord;

public static class SP_MaintenanceRecords_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_maintenance_records_get_by_id;

                                  CREATE PROCEDURE sp_maintenance_records_get_by_id (
                                      IN p_maintenance_record_id INT
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
                                      WHERE id = p_maintenance_record_id;
                                  END;
                                  """;
}