namespace VRMS.Database.StoredProcedureImplementations.Fleet.MaintenanceRecord;

public static class SP_MaintenanceRecords_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_maintenance_records_create;

                                  CREATE PROCEDURE sp_maintenance_records_create (
                                      IN p_vehicle_id INT,
                                      IN p_description TEXT,
                                      IN p_cost DECIMAL(10,2),
                                      IN p_start_date DATE
                                  )
                                  BEGIN
                                      INSERT INTO maintenance_records (
                                          vehicle_id,
                                          description,
                                          cost,
                                          start_date
                                      )
                                      VALUES (
                                          p_vehicle_id,
                                          p_description,
                                          p_cost,
                                          p_start_date
                                      );

                                      SELECT LAST_INSERT_ID() AS maintenance_record_id;
                                  END;
                                  """;
}