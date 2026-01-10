namespace VRMS.Database.StoredProcedureImplementations.Customers.DriversLicense;

public static class SP_DriversLicenses_SetFrontPhoto
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_drivers_licenses_set_front_photo;

                                  CREATE PROCEDURE sp_drivers_licenses_set_front_photo (
                                      IN p_license_id INT,
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      UPDATE drivers_licenses
                                      SET front_photo_path = p_photo_path
                                      WHERE id = p_license_id;
                                  END;
                                  """;
}