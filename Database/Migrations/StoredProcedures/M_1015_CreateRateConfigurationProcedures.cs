using VRMS.Database.StoredProcedureImplementations.Billing.RateConfiguration;

namespace VRMS.Database.Migrations;

public static class M_1015_CreateRateConfigurationProcedures
{
    public static string Create() => $"""
                                      {SP_RateConfigurations_Create.Sql()}
                                      {SP_RateConfigurations_GetById.Sql()}
                                      {SP_RateConfigurations_GetByCategory.Sql()}
                                      {SP_RateConfigurations_Update.Sql()}
                                      {SP_RateConfigurations_Delete.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_rate_configurations_create;
                                   DROP PROCEDURE IF EXISTS sp_rate_configurations_get_by_id;
                                   DROP PROCEDURE IF EXISTS sp_rate_configurations_get_by_category;
                                   DROP PROCEDURE IF EXISTS sp_rate_configurations_update;
                                   DROP PROCEDURE IF EXISTS sp_rate_configurations_delete;
                                   """;
}