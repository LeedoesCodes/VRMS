namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContact;

public static class SP_EmergencyContacts_GetByCustomerId
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contacts_get_by_customer_id;

                                  CREATE PROCEDURE sp_emergency_contacts_get_by_customer_id (
                                      IN p_customer_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          customer_id,
                                          first_name,
                                          last_name,
                                          relationship
                                      FROM emergency_contacts
                                      WHERE customer_id = p_customer_id;
                                  END;
                                  """;
}