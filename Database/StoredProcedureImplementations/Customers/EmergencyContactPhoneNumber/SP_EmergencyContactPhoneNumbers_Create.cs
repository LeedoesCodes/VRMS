namespace VRMS.Database.StoredProcedureImplementations.Customers.EmergencyContactPhoneNumber;

public static class SP_EmergencyContactPhoneNumbers_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_emergency_contact_phone_numbers_create;

                                  CREATE PROCEDURE sp_emergency_contact_phone_numbers_create (
                                      IN p_emergency_contact_id INT,
                                      IN p_phone_number VARCHAR(30)
                                  )
                                  BEGIN
                                      INSERT INTO emergency_contact_phone_numbers (
                                          emergency_contact_id,
                                          phone_number
                                      )
                                      VALUES (
                                          p_emergency_contact_id,
                                          p_phone_number
                                      );

                                      SELECT LAST_INSERT_ID() AS phone_number_id;
                                  END;
                                  """;
}