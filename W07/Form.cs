using System;
using System.Collections.Generic;
using System.Text;

namespace W07
{
    public class Form
    {
        public void Initialize()
        {
            Button btOpenFile = new Button();
            btOpenFile.Name = "Open File";

            WordDocument fileWord = new WordDocument();
            fileWord.FileName = "Document.docx";

            btOpenFile.OnClickButton += (button) =>
            {

                fileWord.FileOpenEvent += (fileName) =>
                {
                    Console.WriteLine("Reading file: " + fileName);
                };

                fileWord.Open();
            };

            btOpenFile.Click();

            Button btPrintFile = new Button();
            btPrintFile.Name = "btPrint";

            btPrintFile.OnClickButton += (button) =>
            {
                fileWord.PrintEvent += (properties) =>
                {
                    Console.WriteLine("Print: " + properties);
                };


                fileWord.Print(GetSetting());
            };

            btPrintFile.Click();

        }

        public PrintSetting GetSetting()
        {
            PrintSetting setting = new PrintSetting();
            Console.WriteLine("Select printer: ");
            setting.PrinterName = Console.ReadLine();
            Console.WriteLine("Select start page: ");
            setting.FromPage = int.Parse(Console.ReadLine());
            Console.WriteLine("Select end page: ");
            setting.ToPage = int.Parse(Console.ReadLine());
            Console.WriteLine("How many copies: ");
            setting.Copies = int.Parse(Console.ReadLine());
            Console.WriteLine("Select page size: ");
            try
            {
                setting.PageSize = (PageSize)Enum.Parse(typeof(PageSize), Console.ReadLine());
            }
            catch
            {
                setting.PageSize = PageSize.A4;
            }
            return setting;

        }
    }
}
