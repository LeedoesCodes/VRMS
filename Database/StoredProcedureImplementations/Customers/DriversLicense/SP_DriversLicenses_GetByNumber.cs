namespace VRMS.Database.StoredProcedureImplementations.Customers.DriversLicense;

public static class SP_DriversLicenses_GetByNumber
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_drivers_licenses_get_by_number;

                                  CREATE PROCEDURE sp_drivers_licenses_get_by_number (
                                      IN p_license_number VARCHAR(50)
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          license_number,
                                          issue_date,
                                          expiry_date,
                                          issuing_country,
                                          front_photo_path,
                                          back_photo_path
                                      FROM drivers_licenses
                                      WHERE license_number = p_license_number;
                                  END;
                                  """;
}