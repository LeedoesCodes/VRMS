namespace VRMS.Database.Migrations.Tables;

public static class M_0023_CreateSystemActivityLogsTable
{
    public static string Create() => """
                                         CREATE TABLE IF NOT EXISTS system_activity_logs (
                                             id INT AUTO_INCREMENT PRIMARY KEY,

                                             action VARCHAR(100) NOT NULL,
                                             entity VARCHAR(100) NOT NULL,
                                             entity_id INT NULL,

                                             description VARCHAR(255) NOT NULL,

                                             performed_by_user_id INT NOT NULL,
                                             created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

                                             CONSTRAINT fk_system_activity_logs_user
                                                 FOREIGN KEY (performed_by_user_id)
                                                 REFERENCES users(id)
                                                 ON DELETE RESTRICT
                                         ) ENGINE=InnoDB;
                                     """;

    public static string Drop() => """
                                       DROP TABLE IF EXISTS system_activity_logs;
                                   """;
}