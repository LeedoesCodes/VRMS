namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContact;

public static class SP_EmergencyContacts_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contacts_update;

                                  CREATE PROCEDURE sp_emergency_contacts_update (
                                      IN p_emergency_contact_id INT,
                                      IN p_first_name VARCHAR(50),
                                      IN p_last_name VARCHAR(50),
                                      IN p_relationship VARCHAR(50)
                                  )
                                  BEGIN
                                      UPDATE emergency_contacts
                                      SET
                                          first_name = p_first_name,
                                          last_name = p_last_name,
                                          relationship = p_relationship
                                      WHERE id = p_emergency_contact_id;
                                  END;
                                  """;
}