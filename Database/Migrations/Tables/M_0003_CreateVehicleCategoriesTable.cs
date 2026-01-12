namespace VRMS.Database.Migrations.Tables;

public static class M_0003_CreateVehicleCategoriesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS vehicle_categories (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         name VARCHAR(50) NOT NULL UNIQUE,
                                         description TEXT NULL,
                                         security_deposit DECIMAL(10,2) NOT NULL DEFAULT 0
                                     );
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS vehicle_categories;
                                   """;
}