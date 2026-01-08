namespace VRMS.Database.StoredProcedures.Fleet.VehicleCategories;

public static class SP_VehicleCategories_GetAll
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_categories_get_all;

                                  CREATE PROCEDURE sp_vehicle_categories_get_all ()
                                  BEGIN
                                      SELECT
                                          id,
                                          name,
                                          description
                                      FROM vehicle_categories
                                      ORDER BY name;
                                  END;
                                  """;
}