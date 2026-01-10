namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContactPhoneNumber;

public static class SP_EmergencyContactPhoneNumbers_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contact_phone_numbers_delete;

                                  CREATE PROCEDURE sp_emergency_contact_phone_numbers_delete (
                                      IN p_phone_number_id INT
                                  )
                                  BEGIN
                                      DELETE FROM emergency_contact_phone_numbers
                                      WHERE id = p_phone_number_id;
                                  END;
                                  """;
}