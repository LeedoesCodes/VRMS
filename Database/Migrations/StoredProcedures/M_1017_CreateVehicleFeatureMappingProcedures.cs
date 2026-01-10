using VRMS.Database.StoredProcedureImplementations.Fleet.VehicleFeatureMapping;

namespace VRMS.Database.Migrations;

public static class M_1017_CreateVehicleFeatureMappingProcedures
{
    public static string Create() => $"""
                                      {SP_VehicleFeatureMappings_Add.Sql()}
                                      {SP_VehicleFeatureMappings_Remove.Sql()}
                                      {SP_VehicleFeatureMappings_GetByVehicle.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_add;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_remove;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_get_by_vehicle;
                                   """;
}