namespace VRMS.Database.Tables;

public static class M_0012_CreateDamagesTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS damages (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         description TEXT NOT NULL,
                                         estimated_cost DECIMAL(10,2) NOT NULL
                                     );
                                     """;
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS damages;
                                   """;
}