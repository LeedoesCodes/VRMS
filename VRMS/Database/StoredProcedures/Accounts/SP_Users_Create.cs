namespace VRMS.Database.StoredProcedures.Accounts;

public static class SP_Users_Create
{
    public static string Sql() => """
                                  
                                  DROP PROCEDURE IF EXISTS sp_users_create;
                                  
                                  CREATE PROCEDURE sp_users_create (
                                      IN p_username VARCHAR(50),
                                      IN p_password_hash VARCHAR(255),
                                      IN p_role ENUM('Admin','RentalAgent'),
                                      IN p_is_active BOOLEAN
                                  )
                                  BEGIN
                                      INSERT INTO users (
                                          username,
                                          password_hash,
                                          role,
                                          is_active
                                      )
                                      VALUES (
                                          p_username,
                                          p_password_hash,
                                          p_role,
                                          p_is_active
                                      );

                                      SELECT LAST_INSERT_ID() AS user_id;
                                  END;
                                  """;
}