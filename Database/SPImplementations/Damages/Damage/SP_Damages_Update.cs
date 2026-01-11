namespace VRMS.Database.SPImplementations.Damages.Damage;

public static class SP_Damages_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damages_update;

                                  CREATE PROCEDURE sp_damages_update (
                                      IN p_damage_id INT,
                                      IN p_damage_type VARCHAR(50),
                                      IN p_description TEXT,
                                      IN p_estimated_cost DECIMAL(10,2)
                                  )
                                  BEGIN
                                      UPDATE damages
                                      SET
                                          damage_type = p_damage_type,
                                          description = p_description,
                                          estimated_cost = p_estimated_cost
                                      WHERE id = p_damage_id;
                                  END;
                                  """;

}