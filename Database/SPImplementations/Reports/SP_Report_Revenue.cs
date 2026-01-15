namespace VRMS.Database.SPImplementations.Reports;

public static class SP_Report_Revenue
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_report_revenue;

                                  CREATE PROCEDURE sp_report_revenue(
                                      IN p_from DATE,
                                      IN p_to DATE
                                  )
                                  BEGIN
                                      SELECT
                                          i.id AS invoice_id,
                                          i.rental_id,
                                          v.vehicle_code,
                                          i.generated_date AS invoice_date,
                                          i.total_amount AS amount,
                                          CASE
                                              WHEN i.status = 'Paid' THEN 1
                                              ELSE 0
                                          END AS is_paid

                                      FROM invoices i
                                      JOIN rentals r
                                          ON r.id = i.rental_id
                                      JOIN vehicles v
                                          ON v.id = r.vehicle_id

                                      WHERE DATE(i.generated_date)
                                          BETWEEN p_from AND p_to

                                      ORDER BY i.generated_date DESC;
                                  END;
                                  """;
}