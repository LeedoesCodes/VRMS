namespace VRMS.Database.StoredProcedures.Customers.Customer;

public static class SP_Customers_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customers_create;

                                  CREATE PROCEDURE sp_customers_create (
                                      IN p_first_name VARCHAR(50),
                                      IN p_last_name VARCHAR(50),
                                      IN p_email VARCHAR(100),
                                      IN p_phone VARCHAR(30),
                                      IN p_date_of_birth DATE,
                                      IN p_customer_type ENUM('Regular','VIP'),
                                      IN p_drivers_license_id INT
                                  )
                                  BEGIN
                                      INSERT INTO customers (
                                          first_name,
                                          last_name,
                                          email,
                                          phone,
                                          date_of_birth,
                                          customer_type,
                                          drivers_license_id
                                      )
                                      VALUES (
                                          p_first_name,
                                          p_last_name,
                                          p_email,
                                          p_phone,
                                          p_date_of_birth,
                                          p_customer_type,
                                          p_drivers_license_id
                                      );

                                      SELECT LAST_INSERT_ID() AS customer_id;
                                  END;
                                  """;
}