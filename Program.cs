using System;
using System.Windows.Forms;

namespace BpacBarcode
{
    static class Program
    {
        static int exitCode = 0;

        [STAThread]
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BarcodeForm());
            string[] args = Environment.GetCommandLineArgs();

            return exitCode;
        }

        public static void ExitApplication(int exitCode = 0)
        {
            Program.exitCode = exitCode;
            Application.Exit();
        }

    }
}