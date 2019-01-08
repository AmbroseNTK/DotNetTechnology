using System;
using System.Collections.Generic;
using System.Text;

namespace W07
{
    public delegate void PrintHandle(PrintSetting properties);
    public class WordDocument : File
    {

        public event PrintHandle PrintEvent;

        public override void Open()
        {
            base.Open();
            Console.WriteLine("Opening Word document...");

        }

        public void Print(PrintSetting properties)
        {
            Console.WriteLine("Printing...");
            PrintEvent(properties);
            //
        }

    }
}
