using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using VRMS.Database;
using VRMS.Database.Executors;
using VRMS.Forms;
using VRMS.Terminal;
using VRMS.UI.Forms;

namespace VRMS
{
    internal static class Program
    {
        // Global session info (used by MainForm)
        public static string CurrentUsername { get; set; } = "Guest";
        public static string CurrentUserRole { get; set; } = "User";

        [STAThread]
        static void Main(string[] args)
        {
            // ----------------------------
            // Load configuration
            // ----------------------------
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("Default")
                                   ?? throw new InvalidOperationException(
                                       "Connection string 'Default' is missing in appsettings.json");

            DB.Initialize(connectionString);

            // ----------------------------
            // CLI MODE
            // ----------------------------
            if (args.Length > 0)
            {
                if (CommandDispatcher.TryExecute(args, out var result))
                {
                    Console.WriteLine(result!.Message);
                    Environment.Exit(result.Success ? 0 : 1);
                }

                Console.Error.WriteLine($"Unknown command: {args[0]}");
                Environment.Exit(1);
            }

            // ----------------------------
            // GUI MODE
            // ----------------------------
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }

    }
}