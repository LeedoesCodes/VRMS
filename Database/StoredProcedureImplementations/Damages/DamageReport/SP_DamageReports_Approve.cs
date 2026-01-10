namespace VRMS.Database.StoredProcedureImplementations.Damages.DamageReport;

public static class SP_DamageReports_Approve
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damage_reports_approve;

                                  CREATE PROCEDURE sp_damage_reports_approve (
                                      IN p_damage_report_id INT
                                  )
                                  BEGIN
                                      UPDATE damage_reports
                                      SET approved = TRUE
                                      WHERE id = p_damage_report_id;
                                  END;
                                  """;
}