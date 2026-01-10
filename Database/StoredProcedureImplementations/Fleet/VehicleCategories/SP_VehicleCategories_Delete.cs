namespace VRMS.Database.StoredProcedureImplementations.Fleet.VehicleCategories;

public static class SP_VehicleCategories_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_categories_delete;

                                  CREATE PROCEDURE sp_vehicle_categories_delete (
                                      IN p_category_id INT
                                  )
                                  BEGIN
                                      DELETE FROM vehicle_categories
                                      WHERE id = p_category_id;
                                  END;
                                  """;
}