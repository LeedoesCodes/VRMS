namespace VRMS.Database.Tables;

public static class M_0009_CreateReservationsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS reservations (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         customer_id INT NOT NULL,
                                         vehicle_id INT NOT NULL,
                                         start_date DATETIME NOT NULL,
                                         end_date DATETIME NOT NULL,
                                         status ENUM('Pending','Confirmed','Cancelled') NOT NULL,

                                         CONSTRAINT fk_reservations_customer
                                             FOREIGN KEY (customer_id)
                                             REFERENCES customers(id)
                                             ON DELETE RESTRICT,

                                         CONSTRAINT fk_reservations_vehicle
                                             FOREIGN KEY (vehicle_id)
                                             REFERENCES vehicles(id)
                                             ON DELETE RESTRICT
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS reservations;
                                   """;

}