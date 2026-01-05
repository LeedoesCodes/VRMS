using System;
using System.Reflection;
using VRMS.Database.Tables;

namespace VRMS.Database.DBHelpers;

/*
HOW TO USE STRICT MODE

Default (STRICT — recommended)
    TableExecutor.ExecuteAllCreates(DB.ExecuteNonQuery);

Explicit strict mode
    TableExecutor.ExecuteAllCreates(DB.ExecuteNonQuery, strictMode: true);

Non-strict mode (development / experimentation)
    TableExecutor.ExecuteAllCreates(DB.ExecuteNonQuery, strictMode: false);

Behavior:
- strictMode = true
    Stops execution immediately on the first failure and throws.
    Application startup fails fast if schema creation is broken.

- strictMode = false
    Logs errors per table and continues executing remaining creates.
*/

public static class TableExecutor
{
    public static void ExecuteAllCreates(
        Action<string> executeNonQuery,
        bool strictMode = true
    )
    {
        var assembly = Assembly.GetAssembly(typeof(M_0001_CreateSchemaInfoTable))
            ?? throw new InvalidOperationException("Failed to locate tables assembly.");

        var tableTypes = assembly
            .GetTypes()
            .Where(t =>
                t.IsClass &&
                t.IsAbstract &&
                t.IsSealed && // static class
                t.Name.StartsWith("M_") &&
                t.GetMethod("Create", BindingFlags.Public | BindingFlags.Static) != null
            )
            .OrderBy(t => t.Name)
            .ToList();

        foreach (var type in tableTypes)
        {
            try
            {
                RunCreate(type, executeNonQuery);
                Console.WriteLine($"[OK] {type.Name}");
            }
            catch (Exception ex)
            {
                var root = ex is TargetInvocationException tie && tie.InnerException != null
                    ? tie.InnerException
                    : ex;

                Console.WriteLine($"[ERROR] {type.Name}");
                Console.WriteLine($"        {root.GetType().Name}: {root.Message}");

                if (strictMode)
                {
                    throw new InvalidOperationException(
                        $"Schema creation failed at {type.Name}",
                        root
                    );
                }
            }
        }
    }

    private static void RunCreate(Type tableType, Action<string> executeNonQuery)
    {
        var createMethod = tableType.GetMethod(
            "Create",
            BindingFlags.Public | BindingFlags.Static
        ) ?? throw new InvalidOperationException(
            $"Create() method not found on {tableType.Name}"
        );

        var sql = createMethod.Invoke(null, null) as string
            ?? throw new InvalidOperationException(
                $"Create() on {tableType.Name} did not return SQL"
            );

        executeNonQuery(sql);
    }
}
