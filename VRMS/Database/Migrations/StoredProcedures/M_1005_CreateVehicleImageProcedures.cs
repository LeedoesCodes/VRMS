using VRMS.Database.StoredProcedures.Fleet.VehicleImages;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1005_CreateVehicleImageProcedures
{
    public static string Create() => $"""
                                      {SP_VehicleImages_Create.Sql()}
                                      {SP_VehicleImages_GetByVehicleId.Sql()}
                                      {SP_VehicleImages_Delete.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_vehicle_images_create;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_images_get_by_vehicle_id;
                                   DROP PROCEDURE IF EXISTS sp_vehicle_images_delete;
                                   """;
}