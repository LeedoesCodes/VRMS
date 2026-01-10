namespace VRMS.Database.StoredProcedureImplementations.Damages.Damage;

public static class SP_Damages_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_create;

                                  CREATE PROCEDURE sp_damages_create (
                                      IN p_description TEXT,
                                      IN p_estimated_cost DECIMAL(10,2)
                                  )
                                  BEGIN
                                      INSERT INTO damages (
                                          description,
                                          estimated_cost
                                      )
                                      VALUES (
                                          p_description,
                                          p_estimated_cost
                                      );

                                      SELECT LAST_INSERT_ID() AS damage_id;
                                  END;
                                  """;
}