using VRMS.Database.DBHelpers;
using VRMS.Database.Tables;

namespace VRMS.Database;

public static class CreateTables
{
    public static void Run(
        Func<string, object?> executeScalar,
        Action<string> executeNonQuery)
    {
        // Ensure schema_info exists
        executeNonQuery(M_0001_CreateSchemaInfoTable.Create());

        // Check if schema already initialized
        var result = executeScalar(M_0001_CreateSchemaInfoTable.CheckInitialized());

        if (result is bool initialized && initialized)
            return;

        // Auto-execute all table creates in order
        TableExecutor.ExecuteAllCreates(executeNonQuery);

        // Mark schema as initialized
        executeNonQuery(M_0001_CreateSchemaInfoTable.InsertInitial());
    }
}