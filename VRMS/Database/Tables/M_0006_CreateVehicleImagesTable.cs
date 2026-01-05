namespace VRMS.Database.Tables;

public static class M_0006_CreateVehicleImagesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS vehicle_images (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         vehicle_id INT NOT NULL,
                                         image_path VARCHAR(255) NOT NULL,

                                         CONSTRAINT fk_vehicle_images_vehicle
                                             FOREIGN KEY (vehicle_id)
                                             REFERENCES vehicles(id)
                                             ON DELETE CASCADE
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS vehicle_images;
                                   """;
}