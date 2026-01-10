namespace VRMS.Database.StoredProcedureImplementations.Damages.DamageReport;

public static class SP_DamageReports_SetPhoto
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damage_reports_set_photo;

                                  CREATE PROCEDURE sp_damage_reports_set_photo (
                                      IN p_damage_report_id INT,
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      UPDATE damage_reports
                                      SET photo_path = p_photo_path
                                      WHERE id = p_damage_report_id;
                                  END;
                                  """;
}