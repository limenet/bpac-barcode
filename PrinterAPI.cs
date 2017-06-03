using System;
using System.Windows.Forms;
using bpac;

namespace BpacBarcode
{
    class PrinterAPI
    {
        private string title;
        private string barcode;
        private string timestamp = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        private int count = 1;

        public PrinterAPI(string title, string barcode)
        {
            this.title = title;
            this.barcode = barcode;
        }

        public PrinterAPI(string title, string barcode, string timestamp)
        {
            this.title = title;
            this.barcode = barcode;
            this.timestamp = timestamp;
        }

        public PrinterAPI(string title, string barcode, string timestamp, int count)
        {
            this.title = title;
            this.barcode = barcode;
            this.timestamp = timestamp;
            this.count = count;
        }

        public void print()
        {
            bpac.DocumentClass doc = new DocumentClass();
            string templatePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + doc.Printer.GetMediaId().ToString() + ".lbx";
            if (doc.Open(templatePath) != false)
            {
                doc.GetObject("title").Text = title;
                doc.GetObject("barcode").Text = barcode;
                doc.GetObject("timestamp").Text = timestamp;

                bpac.PrintOptionConstants printOptions = PrintOptionConstants.bpoAutoCut | PrintOptionConstants.bpoQuality;
                doc.StartPrint("", printOptions);
                doc.PrintOut(count, printOptions);
                doc.EndPrint();
                doc.Close();
            }
            else
            {
                MessageBox.Show("Open() Error: " + doc.ErrorCode + "\nMedia ID" + doc.Printer.GetMediaId().ToString());
            }
        }
    }
}
