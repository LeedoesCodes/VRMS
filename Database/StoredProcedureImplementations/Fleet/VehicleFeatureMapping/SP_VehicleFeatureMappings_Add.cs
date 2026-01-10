namespace VRMS.Database.StoredProcedureImplementations.Fleet.VehicleFeatureMapping;

public static class SP_VehicleFeatureMappings_Add
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_feature_mappings_add;

                                  CREATE PROCEDURE sp_vehicle_feature_mappings_add (
                                      IN p_vehicle_id INT,
                                      IN p_feature_id INT
                                  )
                                  BEGIN
                                      INSERT IGNORE INTO vehicle_feature_mappings (
                                          vehicle_id,
                                          feature_id
                                      )
                                      VALUES (
                                          p_vehicle_id,
                                          p_feature_id
                                      );
                                  END;
                                  """;
}