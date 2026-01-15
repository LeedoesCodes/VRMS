namespace VRMS.Database.Migrations.Tables;

public static class M_0013_CreateDamageReportsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS damage_reports (
                                         id INT AUTO_INCREMENT PRIMARY KEY,

                                         -- EACH PHOTO BELONGS TO ONE DAMAGE
                                         damage_id INT NOT NULL,

                                         photo_path VARCHAR(255) NOT NULL DEFAULT '',
                                         approved BOOLEAN NOT NULL DEFAULT FALSE,

                                         CONSTRAINT fk_damage_reports_damage
                                             FOREIGN KEY (damage_id)
                                             REFERENCES damages(id)
                                             ON DELETE CASCADE
                                     ) ENGINE=InnoDB;
                                     """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS damage_reports;
                                   """;
}

