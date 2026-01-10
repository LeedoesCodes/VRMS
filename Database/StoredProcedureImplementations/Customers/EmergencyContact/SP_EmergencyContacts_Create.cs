namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContact;

public static class SP_EmergencyContacts_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contacts_create;

                                  CREATE PROCEDURE sp_emergency_contacts_create (
                                      IN p_customer_id INT,
                                      IN p_first_name VARCHAR(50),
                                      IN p_last_name VARCHAR(50),
                                      IN p_relationship VARCHAR(50)
                                  )
                                  BEGIN
                                      INSERT INTO emergency_contacts (
                                          customer_id,
                                          first_name,
                                          last_name,
                                          relationship
                                      )
                                      VALUES (
                                          p_customer_id,
                                          p_first_name,
                                          p_last_name,
                                          p_relationship
                                      );

                                      SELECT LAST_INSERT_ID() AS emergency_contact_id;
                                  END;
                                  """;
}