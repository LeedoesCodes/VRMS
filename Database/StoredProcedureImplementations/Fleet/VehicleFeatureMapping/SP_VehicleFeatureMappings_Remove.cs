namespace VRMS.Database.StoredProcedureImplementations.Fleet.VehicleFeatureMapping;

public static class SP_VehicleFeatureMappings_Remove
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_remove;

                                  CREATE PROCEDURE sp_vehicle_feature_mappings_remove (
                                      IN p_vehicle_id INT,
                                      IN p_feature_id INT
                                  )
                                  BEGIN
                                      DELETE FROM vehicle_feature_mappings
                                      WHERE vehicle_id = p_vehicle_id
                                        AND feature_id = p_feature_id;
                                  END;
                                  """;
}