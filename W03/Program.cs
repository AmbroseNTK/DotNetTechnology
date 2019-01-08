using System;

namespace W03
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Hello World";
            value = value.HashingMD5();

            Console.WriteLine(value);
            MyLibrary.CommonUtils.HashingMD5(ref value);

            Console.WriteLine(value);
            MyLibrary.CommonUtils.OpenNotepad(content: value);

            Console.ReadLine();
        }
    }
}
