namespace VRMS.Database.StoredProcedureImplementations.Damages.Damage;

public static class SP_Damages_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_delete;

                                  CREATE PROCEDURE sp_damages_delete (
                                      IN p_damage_id INT
                                  )
                                  BEGIN
                                      DELETE FROM damages
                                      WHERE id = p_damage_id;
                                  END;
                                  """;
}