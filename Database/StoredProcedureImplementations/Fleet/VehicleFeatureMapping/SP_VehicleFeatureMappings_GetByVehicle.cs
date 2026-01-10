namespace VRMS.Database.StoredProcedureImplementations.Fleet.VehicleFeatureMapping;

public static class SP_VehicleFeatureMappings_GetByVehicle
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_get_by_vehicle;

                                  CREATE PROCEDURE sp_vehicle_feature_mappings_get_by_vehicle (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          vfm.vehicle_id,
                                          vfm.feature_id,
                                          vf.name AS feature_name
                                      FROM vehicle_feature_mappings vfm
                                      JOIN vehicle_features vf
                                          ON vfm.feature_id = vf.id
                                      WHERE vfm.vehicle_id = p_vehicle_id
                                      ORDER BY vf.name;
                                  END;
                                  """;
}