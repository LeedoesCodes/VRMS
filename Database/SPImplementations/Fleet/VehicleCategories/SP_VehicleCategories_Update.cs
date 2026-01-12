namespace VRMS.Database.SPImplementations.Fleet.VehicleCategories;

public static class SP_VehicleCategories_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_categories_update;


                                  CREATE PROCEDURE sp_vehicle_categories_update (
                                      IN p_category_id INT,
                                      IN p_name VARCHAR(50),
                                      IN p_description TEXT,
                                      IN p_security_deposit DECIMAL(10,2)
                                  )
                                  BEGIN
                                      UPDATE vehicle_categories
                                      SET
                                      name = p_name,
                                      description = p_description,
                                      security_deposit = p_security_deposit
                                      WHERE id = p_category_id;
                                  END;
                                  """;
}