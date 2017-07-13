using System;
using System.Windows.Forms;
using bpac;

namespace BpacBarcode
{
    class PrinterApi
    {
        private readonly string _title;
        private readonly string _barcode;
        private readonly string _timestamp;
        private readonly int _count;

        private const string TimestampFormat = "dd.MM.yyyy HH:mm";

        public PrinterApi(string title, string barcode, string timestamp = null, int count = 1)
        {
            _title = title;
            _barcode = barcode;
            _timestamp = DateTime.Now.ToString(TimestampFormat);
            if (timestamp != null)
            {
                try
                {
                    _timestamp = DateTime.Parse(timestamp).ToString(TimestampFormat);
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            _count = count;
        }

        public int Print()
        {
            var doc = new DocumentClass();
            var templatePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + doc.Printer.GetMediaId().ToString() + ".lbx";
            if (doc.Open(templatePath))
            {
                doc.GetObject("title").Text = _title;
                doc.GetObject("barcode").Text = _barcode;
                doc.GetObject("timestamp").Text = _timestamp;

                // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                PrintOptionConstants printOptions = PrintOptionConstants.bpoAutoCut | PrintOptionConstants.bpoQuality;
                doc.StartPrint("", printOptions);
                doc.PrintOut(_count, printOptions);
                doc.EndPrint();
                doc.Close();
                return doc.ErrorCode;
            }

            MessageBox.Show(@"Open() Error: " + doc.ErrorCode + @"Media ID" + doc.Printer.GetMediaId().ToString());
            return doc.ErrorCode;
        }
    }
}
