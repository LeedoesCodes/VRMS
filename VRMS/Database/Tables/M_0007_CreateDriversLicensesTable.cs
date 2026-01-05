namespace VRMS.Database.Tables;

public static class M_0007_CreateDriversLicensesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS drivers_licenses (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         license_number VARCHAR(50) NOT NULL UNIQUE,
                                         issue_date DATE NOT NULL,
                                         expiry_date DATE NOT NULL,
                                         issuing_country VARCHAR(50) NOT NULL
                                     );
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS drivers_licenses;
                                   """;
}