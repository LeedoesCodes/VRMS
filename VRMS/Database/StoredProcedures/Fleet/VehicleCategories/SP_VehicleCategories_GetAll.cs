namespace VRMS.Database.StoredProcedures.Fleet.VehicleCategories;

public static class SP_VehicleCategories_GetAll
{
    public static string Sql() => """
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