namespace VRMS.Database.StoredProcedureImplementations.Fleet.Vehicle;

public static class SP_Vehicles_Retire
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicles_retire;

                                  CREATE PROCEDURE sp_vehicles_retire (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      UPDATE vehicles
                                      SET status = 'Retired'
                                      WHERE id = p_vehicle_id;
                                  END;
                                  """;
}