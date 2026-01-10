using VRMS.Database.StoredProcedureImplementations.Fleet.VehicleCategories;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1002_CreateVehicleCategoryProcedures
{
    public static string Create() => $"""
                                      {SP_VehicleCategories_Create.Sql()}
                                      {SP_VehicleCategories_GetById.Sql()}
                                      {SP_VehicleCategories_GetAll.Sql()}
                                      {SP_VehicleCategories_Update.Sql()}
                                      {SP_VehicleCategories_Delete.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_vehicle_categories_create;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_categories_get_by_id;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_categories_get_all;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_categories_update;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_categories_delete;
                                   """;
}