namespace VRMS.Database.StoredProcedures.Customers.Customer;

public static class SP_Customers_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customers_get_by_id;

                                  CREATE PROCEDURE sp_customers_get_by_id (
                                      IN p_customer_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          first_name,
                                          last_name,
                                          email,
                                          phone,
                                          date_of_birth,
                                          customer_type,
                                          drivers_license_id
                                      FROM customers
                                      WHERE id = p_customer_id;
                                  END;
                                  """;
}