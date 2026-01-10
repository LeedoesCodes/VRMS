namespace VRMS.Database.StoredProcedureImplementations.Fleet.VehicleImages;

public static class SP_VehicleImages_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_vehicle_images_delete;

                                  CREATE PROCEDURE sp_vehicle_images_delete (
                                      IN p_id INT
                                  )
                                  BEGIN
                                      DELETE FROM vehicle_images
                                      WHERE id = p_id;
                                  END;
                                  """;
}