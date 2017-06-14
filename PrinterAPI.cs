using System;
using System.Windows.Forms;
using bpac;

namespace BpacBarcode
{
    class PrinterAPI
    {
        private string title;
        private string barcode;
        private string timestamp;
        private int count;

        private string timestampFormat = "dd.MM.yyyy HH:mm";

        public PrinterAPI(string title, string barcode, string timestamp = null, int count = 1)
        {
            this.title = title;
            this.barcode = barcode;
            this.timestamp = DateTime.Now.ToString(timestampFormat);
            if (timestamp != null)
            {
                try
                {
                    this.timestamp = DateTime.Parse(timestamp).ToString(timestampFormat);
                }
                finally { }
            }

            this.count = count;
        }

        public int print()
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
                return doc.ErrorCode;
            }

            MessageBox.Show("Open() Error: " + doc.ErrorCode + "\nMedia ID" + doc.Printer.GetMediaId().ToString());
            return doc.ErrorCode;
        }
    }
}
