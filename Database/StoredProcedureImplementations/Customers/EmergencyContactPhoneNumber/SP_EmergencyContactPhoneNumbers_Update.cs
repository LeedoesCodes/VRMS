namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContactPhoneNumber;

public static class SP_EmergencyContactPhoneNumbers_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contact_phone_numbers_update;

                                  CREATE PROCEDURE sp_emergency_contact_phone_numbers_update (
                                      IN p_phone_number_id INT,
                                      IN p_phone_number VARCHAR(30)
                                  )
                                  BEGIN
                                      UPDATE emergency_contact_phone_numbers
                                      SET
                                          phone_number = p_phone_number
                                      WHERE id = p_phone_number_id;
                                  END;
                                  """;
}