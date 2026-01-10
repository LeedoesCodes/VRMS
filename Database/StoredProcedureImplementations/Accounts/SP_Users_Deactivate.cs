namespace VRMS.Database.StoredProcedureImplementations.Accounts;

public static class SP_Users_Deactivate
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_deactivate;
                                  
                                  CREATE PROCEDURE sp_users_deactivate (
                                      IN p_user_id INT
                                  )
                                  BEGIN
                                      UPDATE users
                                      SET is_active = FALSE
                                      WHERE id = p_user_id;
                                  END;
                                  """;
}