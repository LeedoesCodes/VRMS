namespace VRMS.Database.Tables;

public static class M_0002_CreateUsersTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS users (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         username VARCHAR(50) NOT NULL UNIQUE,
                                         password_hash VARCHAR(255) NOT NULL,
                                         role {Tbl.ToEnum<UserRole>()} NOT NULL
                                         is_active BOOLEAN NOT NULL DEFAULT TRUE
                                     );
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS users;
                                   """;

}