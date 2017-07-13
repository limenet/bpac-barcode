using System;
using System.Globalization;
using System.Windows.Forms;

namespace BpacBarcode
{
    public partial class BarcodeForm : Form
    {

        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();

            if (args.GetLength(0) >= 3)
            {
                var exitCode = new PrinterApi(args[1], args[2], args.Length > 3 ? args[3] : null, args.Length > 4 ? Int32.Parse(args[4]) : 1).Print();
                Close();
                Program.ExitApplication(exitCode);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            (new PrinterApi(txtTitle.Text, txtBarcode.Text, timestamp.Value.ToString("o"), (int)cntCopies.Value)).Print();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Program.ExitApplication();
                    break;
                case Keys.Enter:
                    (new PrinterApi(txtTitle.Text, txtBarcode.Text, timestamp.Value.ToString(CultureInfo.InvariantCulture), (int)cntCopies.Value)).Print();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}