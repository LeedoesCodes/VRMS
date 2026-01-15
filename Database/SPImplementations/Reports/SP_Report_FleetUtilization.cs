namespace VRMS.Database.SPImplementations.Reports;

public static class SP_Report_FleetUtilization
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_report_fleet_utilization;

                                  CREATE PROCEDURE sp_report_fleet_utilization(
                                      IN p_from DATE,
                                      IN p_to DATE
                                  )
                                  BEGIN
                                      SELECT
                                          v.id AS vehicle_id,
                                          v.vehicle_code,
                                          CONCAT(v.make, ' ', v.model) AS make_model,

                                          COALESCE(
                                              SUM(
                                                  GREATEST(
                                                      0,
                                                      DATEDIFF(
                                                          LEAST(COALESCE(r.actual_return_date, p_to), p_to),
                                                          GREATEST(r.pickup_date, p_from)
                                                      )
                                                  )
                                              ),
                                              0
                                          ) AS days_rented,

                                          (DATEDIFF(p_to, p_from) + 1) AS total_days,

                                          ROUND(
                                              COALESCE(
                                                  SUM(
                                                      GREATEST(
                                                          0,
                                                          DATEDIFF(
                                                              LEAST(COALESCE(r.actual_return_date, p_to), p_to),
                                                              GREATEST(r.pickup_date, p_from)
                                                          )
                                                      )
                                                  ),
                                                  0
                                              )
                                              / (DATEDIFF(p_to, p_from) + 1) * 100,
                                              2
                                          ) AS utilization_percent

                                      FROM vehicles v
                                      LEFT JOIN rentals r
                                          ON r.vehicle_id = v.id
                                         AND r.pickup_date <= p_to
                                         AND COALESCE(r.actual_return_date, p_to) >= p_from

                                      GROUP BY v.id, v.vehicle_code, make_model
                                      ORDER BY utilization_percent DESC;
                                  END;
                                  """;
}