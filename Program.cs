using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BpacBarcode
{
    static class Program
    {
        /// <summary>
		/// Main entry point of application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BarcodeForm());
        }
    }
}