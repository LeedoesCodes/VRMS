namespace VRMS.Database.StoredProcedureImplementations.Damages.DamageReport;

public static class SP_DamageReports_GetByInspection
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_damage_reports_get_by_inspection;

                                  CREATE PROCEDURE sp_damage_reports_get_by_inspection (
                                      IN p_vehicle_inspection_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          vehicle_inspection_id,
                                          damage_id,
                                          photo_path,
                                          approved
                                      FROM damage_reports
                                      WHERE vehicle_inspection_id = p_vehicle_inspection_id
                                      ORDER BY id;
                                  END;
                                  """;
}