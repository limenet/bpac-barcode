/***********************************************************************
			b-PAC 3.0 Component Sample (TestPrint)

			(C)Copyright Brother Industries, Ltd. 2009
************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using bpac;

namespace BarcodePrint
{
    public partial class BarcodeForm : Form
    {
        private const string TEMPLATE = @"BcdItem.lbx";

        public BarcodeForm()
        {
            InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            string[] args = Environment.GetCommandLineArgs();

            if (args.GetLength(0) == 3)
            {
                doPrint(args[1], args[2]);
                Close();
            } else if (args.GetLength(0) == 4)
            {
                doPrint(args[1], args[2], Int32.Parse(args[3]));
                Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
		{
            doPrint(txtTitle.Text, txtBarcode.Text, (int) cntCopies.Value);
		}

         private void doPrint(string title, string barcode, int count = 1)
        {
            string templatePath = TEMPLATE;
            bpac.DocumentClass doc = new DocumentClass();
            if (doc.Open(templatePath) != false)
            {
                doc.GetObject("objName").Text = title;
                doc.GetObject("objBarcode").Text = barcode;

                // doc.SetMediaById(doc.Printer.GetMediaId(), true);
                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(count, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            else
            {
                MessageBox.Show("Open() Error: " + doc.ErrorCode);
            }
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
                doPrint(txtTitle.Text, txtBarcode.Text);
            }
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}