namespace VRMS.Database.Tables;

public static class M_0005_CreateVehicleFeaturesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS vehicle_features (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         name VARCHAR(50) NOT NULL UNIQUE
                                     );
                                     """;
    public static string Drop() => """
                                   DROP TABLE IF EXISTS vehicle_features;
                                   """;

}
