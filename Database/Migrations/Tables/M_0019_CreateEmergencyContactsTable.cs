namespace VRMS.Database.Migrations.Tables;

public static class M_0019_CreateEmergencyContactsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS emergency_contacts (
                                         id INT AUTO_INCREMENT PRIMARY KEY,

                                         customer_id INT NOT NULL,

                                         first_name VARCHAR(50) NOT NULL,
                                         last_name VARCHAR(50) NOT NULL,
                                         relationship VARCHAR(50) NOT NULL,

                                         CONSTRAINT fk_emergency_contacts_customer
                                             FOREIGN KEY (customer_id)
                                             REFERENCES customers(id)
                                             ON DELETE CASCADE
                                     ) ENGINE=InnoDB;
                                     """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS emergency_contacts;
                                   """;
}