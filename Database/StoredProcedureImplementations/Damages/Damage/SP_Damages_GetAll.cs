namespace VRMS.Database.StoredProcedureImplementations.Damages.Damage;

public static class SP_Damages_GetAll
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_get_all;

                                  CREATE PROCEDURE sp_damages_get_all ()
                                  BEGIN
                                      SELECT
                                          id,
                                          description,
                                          estimated_cost
                                      FROM damages
                                      ORDER BY id;
                                  END;
                                  """;
}