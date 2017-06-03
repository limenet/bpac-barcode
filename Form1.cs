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

            if (args.GetLength(0) == 3)
            {
                (new PrinterAPI(args[1], args[2])).print();
                Close();
            }
            else if (args.GetLength(0) == 4)
            {
                (new PrinterAPI(args[1], args[2], args[3])).print();
                Close();
            }
            else if (args.GetLength(0) == 5)
            {
                (new PrinterAPI(args[1], args[2], args[3], Int32.Parse(args[4]))).print();
                Close();
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
                Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                (new PrinterAPI(txtTitle.Text, txtBarcode.Text, timestamp.Value.ToString(), (int)cntCopies.Value)).print();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}