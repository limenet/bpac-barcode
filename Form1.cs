using System;
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
            string[] args = Environment.GetCommandLineArgs();

            if (args.GetLength(0) >= 3)
            {
                int exitCode = (new PrinterAPI(args[1], args[2], args.Length > 3 ? args[3] : null, args.Length > 4 ? Int32.Parse(args[4]) : 1).print()) ? 0 : 1;
                Program.ExitApplication(exitCode);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            (new PrinterAPI(txtTitle.Text, txtBarcode.Text, timestamp.Value.ToString(), (int)cntCopies.Value)).print();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Program.ExitApplication(0);
            }
            else if (keyData == Keys.Enter)
            {
                (new PrinterAPI(txtTitle.Text, txtBarcode.Text, timestamp.Value.ToString(), (int)cntCopies.Value)).print();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}