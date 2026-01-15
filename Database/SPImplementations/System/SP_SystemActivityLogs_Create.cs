namespace VRMS.Database.SPImplementations.System;

public static class SP_SystemActivityLogs_Create
{
    public static string Sql() => """
                                      DROP PROCEDURE IF EXISTS sp_system_activity_logs_create;

                                      CREATE PROCEDURE sp_system_activity_logs_create (
                                          IN p_action VARCHAR(100),
                                          IN p_entity VARCHAR(100),
                                          IN p_entity_id INT,
                                          IN p_description VARCHAR(255),
                                          IN p_performed_by_user_id INT
                                      )
                                      BEGIN
                                          INSERT INTO system_activity_logs (
                                              action,
                                              entity,
                                              entity_id,
                                              description,
                                              performed_by_user_id
                                          )
                                          VALUES (
                                              p_action,
                                              p_entity,
                                              p_entity_id,
                                              p_description,
                                              p_performed_by_user_id
                                          );

                                          SELECT LAST_INSERT_ID() AS id;
                                      END;
                                  """;
}