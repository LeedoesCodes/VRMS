namespace VRMS.Database.StoredProcedures.Customers.Customer;

public static class SP_Customers_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customers_update;

                                  CREATE PROCEDURE sp_customers_update (
                                      IN p_customer_id INT,
                                      IN p_first_name VARCHAR(50),
                                      IN p_last_name VARCHAR(50),
                                      IN p_email VARCHAR(100),
                                      IN p_phone VARCHAR(30),
                                      IN p_customer_type ENUM('Regular','VIP')
                                  )
                                  BEGIN
                                      UPDATE customers
                                      SET
                                          first_name = p_first_name,
                                          last_name = p_last_name,
                                          email = p_email,
                                          phone = p_phone,
                                          customer_type = p_customer_type
                                      WHERE id = p_customer_id;
                                  END;
                                  """;
}