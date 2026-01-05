namespace VRMS.Database.Tables;

public static class M_0013_CreateDamageReportsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS damage_reports (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         vehicle_inspection_id INT NOT NULL,
                                         damage_id INT NOT NULL,
                                         photo_path VARCHAR(255) NOT NULL,
                                         approved BOOLEAN NOT NULL DEFAULT FALSE,

                                         CONSTRAINT fk_damage_reports_inspection
                                             FOREIGN KEY (vehicle_inspection_id)
                                             REFERENCES vehicle_inspections(id)
                                             ON DELETE CASCADE,

                                         CONSTRAINT fk_damage_reports_damage
                                             FOREIGN KEY (damage_id)
                                             REFERENCES damages(id)
                                             ON DELETE RESTRICT
                                     ) ENGINE=InnoDB;
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS damage_reports;
                                   """;
    
    
}
