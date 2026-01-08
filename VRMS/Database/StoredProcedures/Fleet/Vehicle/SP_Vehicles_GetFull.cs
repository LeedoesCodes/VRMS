namespace VRMS.Database.StoredProcedures.Fleet.Vehicle;

public static class SP_Vehicles_GetFull
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicles_get_full;

                                  CREATE PROCEDURE sp_vehicles_get_full (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          v.*,
                                          vc.name AS category_name,
                                          vc.description AS category_description
                                      FROM vehicles v
                                      JOIN vehicle_categories vc
                                          ON v.vehicle_category_id = vc.id
                                      WHERE v.id = p_vehicle_id;
                                  END;
                                  """;
}
