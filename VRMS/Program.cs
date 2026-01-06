using System;
using System.Windows.Forms;
using Vehicle_Rental_Management_System;

namespace VRMS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }
    }
}
