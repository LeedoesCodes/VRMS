namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_TodaySchedule
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_today_schedule;

                                  CREATE PROCEDURE sp_dashboard_today_schedule()
                                  BEGIN
                                      -- =========================
                                      -- PICKUPS (RENTALS STARTING TODAY)
                                      -- =========================
                                      SELECT
                                          'Pickup' AS type,
                                          CONCAT(v.make, ' ', v.model, ' (', v.license_plate, ')') AS vehicle,
                                          CONCAT(c.first_name, ' ', c.last_name) AS customer,
                                          r.status AS status
                                      FROM rentals r
                                      JOIN vehicles v ON v.id = r.vehicle_id
                                      JOIN customers c ON c.id = r.customer_id
                                      WHERE DATE(r.pickup_date) = CURDATE()

                                      UNION ALL

                                      -- =========================
                                      -- RETURNS (RENTALS DUE TODAY)
                                      -- =========================
                                      SELECT
                                          'Return' AS type,
                                          CONCAT(v.make, ' ', v.model, ' (', v.license_plate, ')') AS vehicle,
                                          CONCAT(c.first_name, ' ', c.last_name) AS customer,
                                          r.status AS status
                                      FROM rentals r
                                      JOIN vehicles v ON v.id = r.vehicle_id
                                      JOIN customers c ON c.id = r.customer_id
                                      WHERE DATE(r.expected_return_date) = CURDATE()
                                        AND r.status <> 'Completed'

                                      ORDER BY type DESC;
                                  END;
                                  """;
}