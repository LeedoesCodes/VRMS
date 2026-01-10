namespace VRMS.Database.StoredProcedureImplementations.Billing.RateConfiguration;

public static class SP_RateConfigurations_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_rate_configurations_delete;

                                  CREATE PROCEDURE sp_rate_configurations_delete (
                                      IN p_rate_configuration_id INT
                                  )
                                  BEGIN
                                      DELETE FROM rate_configurations
                                      WHERE id = p_rate_configuration_id;
                                  END;
                                  """;
}