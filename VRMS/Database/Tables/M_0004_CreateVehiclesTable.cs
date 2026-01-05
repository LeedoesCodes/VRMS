namespace VRMS.Database.Tables;

public static class M_0004_CreateVehiclesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS vehicles (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         vehicle_code VARCHAR(50) NOT NULL UNIQUE,
                                         make VARCHAR(50) NOT NULL,
                                         model VARCHAR(50) NOT NULL,
                                         year INT NOT NULL,
                                         color VARCHAR(30) NOT NULL,
                                         license_plate VARCHAR(20) NOT NULL UNIQUE,
                                         vin VARCHAR(50) NOT NULL UNIQUE,
                                         transmission ENUM('Manual','Automatic') NOT NULL,
                                         fuel_type ENUM('Gasoline','Diesel','Electric','Hybrid') NOT NULL,
                                         status ENUM('Available','Reserved','Rented','UnderMaintenance','OutOfService','Retired') NOT NULL,
                                         seating_capacity INT NOT NULL,
                                         odometer INT NOT NULL,
                                         vehicle_category_id INT NOT NULL,

                                         CONSTRAINT fk_vehicles_category
                                             FOREIGN KEY (vehicle_category_id)
                                             REFERENCES vehicle_categories(id)
                                             ON DELETE RESTRICT
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS vehicles;
                                   """;
}
