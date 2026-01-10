namespace VRMS.Database.StoredProcedureImplementations.Customers.DriversLicense;

public static class SP_DriversLicenses_ResetPhotos
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_drivers_licenses_reset_photos;

                                  CREATE PROCEDURE sp_drivers_licenses_reset_photos (
                                      IN p_license_id INT
                                  )
                                  BEGIN
                                      UPDATE drivers_licenses
                                      SET
                                          front_photo_path = 'Assets/img_placeholder.png',
                                          back_photo_path  = 'Assets/img_placeholder.png'
                                      WHERE id = p_license_id;
                                  END;
                                  """;
}