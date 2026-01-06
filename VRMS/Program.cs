using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    static class Program
    {
        // Global variables to store session data
        public static string CurrentUsername { get; set; } = "Guest";
        public static string CurrentUserRole { get; set; } = "User";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}