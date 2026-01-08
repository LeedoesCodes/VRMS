namespace VRMS.Database.StoredProcedures.Fleet.Vehicle;

public static class SP_Vehicles_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicles_get_by_id;

                                  CREATE PROCEDURE sp_vehicles_get_by_id (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM vehicles
                                      WHERE id = p_vehicle_id;
                                  END;
                                  """;
}
