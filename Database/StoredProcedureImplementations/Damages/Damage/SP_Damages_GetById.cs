namespace VRMS.Database.StoredProcedureImplementations.Damages.Damage;

public static class SP_Damages_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_get_by_id;

                                  CREATE PROCEDURE sp_damages_get_by_id (
                                      IN p_damage_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          description,
                                          estimated_cost
                                      FROM damages
                                      WHERE id = p_damage_id;
                                  END;
                                  """;
}