namespace VRMS.Database.Tables;

public static class M_0011_CreateVehicleInspectionsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS vehicle_inspections (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         rental_id INT NOT NULL,
                                         inspection_type ENUM('Pickup','Return') NOT NULL,
                                         notes TEXT NOT NULL,
                                         fuel_level VARCHAR(20) NOT NULL,
                                         cleanliness VARCHAR(20) NOT NULL,

                                         CONSTRAINT fk_inspections_rental
                                             FOREIGN KEY (rental_id)
                                             REFERENCES rentals(id)
                                             ON DELETE CASCADE
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS vehicle_inspections;
                                   """;
}