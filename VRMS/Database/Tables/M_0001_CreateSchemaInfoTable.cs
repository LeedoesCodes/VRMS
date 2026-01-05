namespace VRMS.Database.Tables;

public static class M_0001_CreateSchemaInfoTable
{
    public static string Create() => 
        """
        CREATE TABLE IF NOT EXISTS schema_info (
             id INT PRIMARY KEY,
             initialized BOOLEAN NOT NULL
        );
        """;

    public static string InsertInitial() => 
        """
            INSERT INTO schema_info (id, initialized)
            VALUES (1, TRUE);
        """;

    public static string CheckInitialized() =>
        "SELECT initialized FROM schema_info WHERE id = 1;";
    
    public static string Drop() => """
                                   DROP TABLE IF EXISTS schema_info;
                                   """;
}