using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using VRMS.Database;
using VRMS.Terminal;

namespace VRMS
{
    internal static class Program
    {
        public static string CurrentUsername { get; set; } = "Guest";
        public static string CurrentUserRole { get; set; } = "User";

        [STAThread]
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("Default");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Connection string 'Default' is missing in appsettings.json");
            }

            DB.Initialize(connectionString);

            // ----------------------------
            // Handle terminal commands
            // ----------------------------
            if (CommandDispatcher.TryExecute(args, out var result))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using var context = new ApplicationContext();

                Task.Run(() =>
                {
                    MessageBox.Show(
                        result!.Message,
                        result.Success ? "Success" : "Error",
                        MessageBoxButtons.OK,
                        result.Success
                            ? MessageBoxIcon.Information
                            : MessageBoxIcon.Error
                    );

                    context.ExitThread();
                });

                Application.Run(context);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
