namespace VRMS.Database.StoredProcedures.Fleet.Vehicle;

public static class SP_Vehicles_UpdateStatus
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicles_update_status;

                                  CREATE PROCEDURE sp_vehicles_update_status (
                                      IN p_vehicle_id INT,
                                      IN p_status ENUM('Available','Rented','Maintenance','Retired')
                                  )
                                  BEGIN
                                      UPDATE vehicles
                                      SET status = p_status
                                      WHERE id = p_vehicle_id;
                                  END;
                                  """;
}