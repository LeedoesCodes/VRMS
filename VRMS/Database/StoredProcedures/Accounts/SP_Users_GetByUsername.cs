namespace VRMS.Database.StoredProcedures.Accounts;

public static class SP_Users_GetByUsername
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_get_by_username;
                                  
                                  CREATE PROCEDURE sp_users_get_by_username (
                                      IN p_username VARCHAR(50)
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          username,
                                          password_hash,
                                          role,
                                          is_active
                                      FROM users
                                      WHERE username = p_username;
                                  END;
                                  """;
}