namespace VRMS.Database.Tables;

public static class M_0008_CreateCustomersTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS customers (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         first_name VARCHAR(50) NOT NULL,
                                         last_name VARCHAR(50) NOT NULL,
                                         email VARCHAR(100) NOT NULL,
                                         phone VARCHAR(30) NOT NULL,
                                         date_of_birth DATE NOT NULL,
                                         customer_type ENUM('Individual','Corporate','Frequent','Blacklisted') NOT NULL,
                                         drivers_license_id INT NOT NULL,

                                         CONSTRAINT fk_customers_license
                                             FOREIGN KEY (drivers_license_id)
                                             REFERENCES drivers_licenses(id)
                                             ON DELETE RESTRICT
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS customers;
                                   """;

}
