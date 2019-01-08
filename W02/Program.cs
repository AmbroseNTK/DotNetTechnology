using MyLibrary;
using System;
using System.Collections.Generic;

namespace W02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>() { "int", "float", "double", "bool" };
            ChoosableMenu choosableMenu = new ChoosableMenu(menu);

            choosableMenu.MainBackground = ConsoleColor.White;
            choosableMenu.MainForeground = ConsoleColor.Black;
            choosableMenu.SelectionBackground = ConsoleColor.DarkBlue;
            choosableMenu.SelectionForeground = ConsoleColor.White;

            choosableMenu.EnablePointer = true;
            choosableMenu.EnableIndex = true;
            choosableMenu.Pointer = '*';

            try
            {
                Console.WriteLine("Enter value:");
                string val = Console.ReadLine();
                Console.WriteLine("Select data type:");
                Type t;
                switch (choosableMenu.ShowMenu())
                {
                    case 0:
                        Console.WriteLine(MyLibrary.MyConverter.Parse<int>(val));
                        break;
                    case 1:
                        Console.WriteLine(MyLibrary.MyConverter.Parse<float>(val));
                        break;
                    case 2:
                        Console.WriteLine(MyLibrary.MyConverter.Parse<double>(val));
                        break;
                    case 3:
                        Console.WriteLine(MyLibrary.MyConverter.Parse<bool>(val));
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
