namespace VRMS.Database.SPImplementations.Fleet.VehicleCategories;

public static class SP_VehicleCategories_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_categories_get_by_id;


                                  CREATE PROCEDURE sp_vehicle_categories_get_by_id (
                                  IN p_category_id INT
                                  )
                                  BEGIN
                                  SELECT
                                      id,
                                      name,
                                      description,
                                      security_deposit
                                      FROM vehicle_categories
                                      WHERE id = p_category_id;
                                  END;
                                  """;
}