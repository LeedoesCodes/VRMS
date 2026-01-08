namespace VRMS.Database.StoredProcedures.Customers.DriversLicense;

public static class SP_DriversLicenses_Update
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_drivers_licenses_update;

                                  CREATE PROCEDURE sp_drivers_licenses_update (
                                      IN p_license_id INT,
                                      IN p_issue_date DATE,
                                      IN p_expiry_date DATE,
                                      IN p_issuing_country VARCHAR(50)
                                  )
                                  BEGIN
                                      UPDATE drivers_licenses
                                      SET
                                          issue_date = p_issue_date,
                                          expiry_date = p_expiry_date,
                                          issuing_country = p_issuing_country
                                      WHERE id = p_license_id;
                                  END;
                                  """;
}