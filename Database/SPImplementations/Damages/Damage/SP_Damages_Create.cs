namespace VRMS.Database.SPImplementations.Damages.Damage;

public static class SP_Damages_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_create;

                                  CREATE PROCEDURE sp_damages_create (
                                      IN p_damage_type VARCHAR(50),
                                      IN p_description TEXT,
                                      IN p_estimated_cost DECIMAL(10,2)
                                  )
                                  BEGIN
                                      INSERT INTO damages (
                                          damage_type,
                                          description,
                                          estimated_cost
                                      )
                                      VALUES (
                                          p_damage_type,
                                          p_description,
                                          p_estimated_cost
                                      );

                                      SELECT LAST_INSERT_ID() AS damage_id;
                                  END;
                                  """;

}