namespace VRMS.Database.StoredProcedureImplementations.Billing.RateConfiguration;

public static class SP_RateConfigurations_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_rate_configurations_create;

                                  CREATE PROCEDURE sp_rate_configurations_create (
                                      IN p_vehicle_category_id INT,
                                      IN p_daily_rate DECIMAL(10,2),
                                      IN p_weekly_rate DECIMAL(10,2),
                                      IN p_monthly_rate DECIMAL(10,2),
                                      IN p_hourly_rate DECIMAL(10,2)
                                  )
                                  BEGIN
                                      INSERT INTO rate_configurations (
                                          vehicle_category_id,
                                          daily_rate,
                                          weekly_rate,
                                          monthly_rate,
                                          hourly_rate
                                      )
                                      VALUES (
                                          p_vehicle_category_id,
                                          p_daily_rate,
                                          p_weekly_rate,
                                          p_monthly_rate,
                                          p_hourly_rate
                                      );

                                      SELECT LAST_INSERT_ID() AS rate_configuration_id;
                                  END;
                                  """;
}