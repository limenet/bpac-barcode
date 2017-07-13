using System;
using System.Windows.Forms;

namespace BpacBarcode
{
    static class Program
    {
        static int _exitCode;

        [STAThread]
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BarcodeForm());

            return _exitCode;
        }

        public static void ExitApplication(int exitCode = 0)
        {
            _exitCode = exitCode;
            Application.Exit();
        }

    }
}