namespace VRMS.Database.StoredProcedureImplementations.Damages.DamageReport;

public static class SP_DamageReports_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damage_reports_create;

                                  CREATE PROCEDURE sp_damage_reports_create (
                                      IN p_vehicle_inspection_id INT,
                                      IN p_damage_id INT,
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      INSERT INTO damage_reports (
                                          vehicle_inspection_id,
                                          damage_id,
                                          photo_path,
                                          approved
                                      )
                                      VALUES (
                                          p_vehicle_inspection_id,
                                          p_damage_id,
                                          p_photo_path,
                                          FALSE
                                      );

                                      SELECT LAST_INSERT_ID() AS damage_report_id;
                                  END;
                                  """;
}