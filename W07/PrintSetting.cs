using System;
using System.Collections.Generic;
using System.Text;

namespace W07
{
    public enum PageSize
    {
        A4,
        A3,
        A5,
        Letter
    }

    public class PrintSetting
    {
        private string printerName;
        private int fromPage;
        private int toPage;
        private int copies;
        private PageSize pageSize;

        public string PrinterName { get => printerName; set => printerName = value; }
        public int FromPage { get => fromPage; set => fromPage = value; }
        public int ToPage { get => toPage; set => toPage = value; }
        public int Copies { get => copies; set => copies = value; }
        public PageSize PageSize { get => pageSize; set => pageSize = value; }

        public override string ToString()
        {
            return $"Printer Name: {printerName}\nFrom Page: {fromPage}\nTo Page: {toPage}\nCopies: {copies}\nPage size: {pageSize}\n";
        }
    }
}
