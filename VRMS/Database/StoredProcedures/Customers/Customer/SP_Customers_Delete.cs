namespace VRMS.Database.StoredProcedures.Customers.Customer;

public static class SP_Customers_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customers_delete;

                                  CREATE PROCEDURE sp_customers_delete (
                                      IN p_customer_id INT
                                  )
                                  BEGIN
                                      DELETE FROM customers
                                      WHERE id = p_customer_id;
                                  END;
                                  """;
}