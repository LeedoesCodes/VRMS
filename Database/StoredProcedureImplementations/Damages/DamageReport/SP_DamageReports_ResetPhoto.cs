namespace VRMS.Database.StoredProcedureImplementations.Damages.DamageReport;

public static class SP_DamageReports_ResetPhoto
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damage_reports_reset_photo;

                                  CREATE PROCEDURE sp_damage_reports_reset_photo (
                                      IN p_damage_report_id INT
                                  )
                                  BEGIN
                                      UPDATE damage_reports
                                      SET photo_path = 'Assets/img_placeholder.png'
                                      WHERE id = p_damage_report_id;
                                  END;
                                  """;
}