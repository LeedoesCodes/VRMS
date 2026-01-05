using VRMS.Database.Tables;

namespace VRMS.Database;

public static class CreateTables
{
    public static void Run(Func<string, object?> executeScalar,
        Action<string> executeNonQuery)
    {
        // Always ensure schema_info exists
        executeNonQuery(M_0001_CreateSchemaInfoTable.Create());

        // Check if schema already initialized
        var result = executeScalar(M_0001_CreateSchemaInfoTable.CheckInitialized());

        if (result is bool initialized && initialized)
        {
            // Already created -> do nothing
            return;
        }

        // ===== CREATE TABLES (ORDER MATTERS) =====
        executeNonQuery(M_0001_CreateSchemaInfoTable.Create());
        executeNonQuery(M_0002_CreateUsersTable.Create());
        executeNonQuery(M_0003_CreateVehicleCategoriesTable.Create());
        executeNonQuery(M_0004_CreateVehiclesTable.Create());
        executeNonQuery(M_0005_CreateVehicleFeaturesTable.Create());
        executeNonQuery(M_0006_CreateVehicleImagesTable.Create());
        executeNonQuery(M_0007_CreateDriversLicensesTable.Create());
        executeNonQuery(M_0008_CreateCustomersTable.Create());
        executeNonQuery(M_0009_CreateReservationsTable.Create());
        executeNonQuery(M_0010_CreateRentalsTable.Create());
        executeNonQuery(M_0011_CreateVehicleInspectionsTable.Create());
        executeNonQuery(M_0012_CreateDamagesTable.Create());
        executeNonQuery(M_0013_CreateDamageReportsTable.Create());
        executeNonQuery(M_0014_CreateInvoicesTable.Create());
        executeNonQuery(M_0015_CreatePaymentsTable.Create());
        executeNonQuery(M_0016_CreateRateConfigurationsTable.Create());
        executeNonQuery(M_0017_CreateMaintenanceRecordsTable.Create());
        

        // Mark schema as initialized
        executeNonQuery(M_0001_CreateSchemaInfoTable.InsertInitial());
    }
}