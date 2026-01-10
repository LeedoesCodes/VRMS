namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContact;

public static class SP_EmergencyContacts_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contacts_delete;

                                  CREATE PROCEDURE sp_emergency_contacts_delete (
                                      IN p_emergency_contact_id INT
                                  )
                                  BEGIN
                                      DELETE FROM emergency_contacts
                                      WHERE id = p_emergency_contact_id;
                                  END;
                                  """;
}