namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_Alerts
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_alerts;

                                  CREATE PROCEDURE sp_dashboard_alerts()
                                  BEGIN
                                      -- =========================
                                      -- OVERDUE RENTALS (CRITICAL)
                                      -- =========================
                                      SELECT
                                          'CRITICAL' AS priority,
                                          CONCAT(
                                              'Overdue: ',
                                              v.make, ' ', v.model, ' (', v.license_plate, ')'
                                          ) AS issue,
                                          CONCAT(
                                              DATEDIFF(NOW(), rt.expected_return_date),
                                              ' Day(s) Late'
                                          ) AS deadline
                                      FROM rentals rt
                                      JOIN vehicles v ON v.id = rt.vehicle_id
                                      WHERE rt.status = 'Active'
                                        AND rt.expected_return_date < NOW()

                                      UNION ALL

                                      -- =========================
                                      -- VEHICLES UNDER MAINTENANCE (HIGH)
                                      -- =========================
                                      SELECT
                                          'HIGH' AS priority,
                                          CONCAT(
                                              'Maintenance: ',
                                              v.make, ' ', v.model, ' (', v.license_plate, ')'
                                          ) AS issue,
                                          'Ongoing' AS deadline
                                      FROM maintenance_records m
                                      JOIN vehicles v ON v.id = m.vehicle_id
                                      WHERE m.end_date IS NULL

                                      ORDER BY
                                          FIELD(priority, 'CRITICAL', 'HIGH');
                                  END;
                                  """;
}