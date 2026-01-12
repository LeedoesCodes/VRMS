namespace VRMS.Database.SPImplementations.Fleet.VehicleCategories;

public static class SP_VehicleCategories_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_categories_create;


                                  CREATE PROCEDURE sp_vehicle_categories_create (
                                      IN p_name VARCHAR(50),
                                      IN p_description TEXT,
                                      IN p_security_deposit DECIMAL(10,2)
                                  )
                                  BEGIN
                                      INSERT INTO vehicle_categories (name, description, security_deposit)
                                      VALUES (p_name, p_description, p_security_deposit);


                                  SELECT LAST_INSERT_ID() AS category_id;
                                  END;
                                  """;
}