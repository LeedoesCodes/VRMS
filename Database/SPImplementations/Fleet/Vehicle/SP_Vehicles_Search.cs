namespace VRMS.Database.SPImplementations.Fleet.Vehicle;

public static class SP_Vehicles_Search
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicles_search;
                                  
                                  CREATE PROCEDURE sp_vehicles_search (
                                      IN p_status VARCHAR(50),
                                      IN p_search VARCHAR(100),
                                      IN p_category_id INT,
                                      IN p_year_from INT,
                                      IN p_year_to INT,
                                      IN p_fuel VARCHAR(50),
                                      IN p_transmission VARCHAR(50)
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM vehicles
                                      WHERE
                                          (p_status IS NULL OR status = p_status)
                                  
                                      AND (p_category_id IS NULL OR vehicle_category_id = p_category_id)
                                  
                                      AND (p_year_from IS NULL OR year >= p_year_from)
                                      AND (p_year_to IS NULL OR year <= p_year_to)
                                  
                                      AND (p_fuel IS NULL OR fuel_type = p_fuel)
                                      AND (p_transmission IS NULL OR transmission = p_transmission)
                                  
                                      AND (
                                          p_search IS NULL
                                          OR make LIKE CONCAT('%', p_search, '%')
                                          OR model LIKE CONCAT('%', p_search, '%')
                                          OR license_plate LIKE CONCAT('%', p_search, '%')
                                          OR vehicle_code LIKE CONCAT('%', p_search, '%')
                                      )
                                      ORDER BY make, model, year DESC;
                                  END;
                                  
                                  """;
}