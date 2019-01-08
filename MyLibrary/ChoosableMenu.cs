using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class ChoosableMenu
    {
        private List<string> menu;

        private ConsoleColor mainBackground;
        private ConsoleColor selectionBackground;
        private ConsoleColor mainForeground;
        private ConsoleColor selectionForeground;
        private bool enableIndex;
        private bool enablePointer;
        private char pointer;

        public List<string> Menu { get => menu; set => menu = value; }
        public ConsoleColor MainBackground { get => mainBackground; set => mainBackground = value; }
        public ConsoleColor SelectionBackground { get => selectionBackground; set => selectionBackground = value; }
        public ConsoleColor MainForeground { get => mainForeground; set => mainForeground = value; }
        public ConsoleColor SelectionForeground { get => selectionForeground; set => selectionForeground = value; }
        public bool EnableIndex { get => enableIndex; set => enableIndex = value; }
        public bool EnablePointer { get => enablePointer; set => enablePointer = value; }
        public char Pointer { get => pointer; set => pointer = value; }

        private int choose = 0;
        public ChoosableMenu(List<string> menu)
        {
            Menu = menu;

        }
        public int ShowMenu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.BackgroundColor = MainBackground;
                Console.ForegroundColor = MainForeground;
                for (int i = 0; i < menu.Count; i++)
                {
                    if (choose == i)
                    {
                        Console.BackgroundColor = SelectionBackground;
                        Console.ForegroundColor = SelectionForeground;
                        if (EnablePointer)
                        {
                            Console.Write(Pointer);
                        }
                        if (EnableIndex)
                        {
                            Console.WriteLine("\t" + (i + 1) + ". " + menu[i]);
                        }
                        else
                        {
                            Console.WriteLine("\t" + menu[i]);
                        }
                        Console.BackgroundColor = MainBackground;
                        Console.ForegroundColor = MainForeground;
                    }
                    else
                    {
                        if (EnableIndex)
                        {
                            Console.WriteLine("\t" + (i + 1) + ". " + menu[i]);
                        }
                        else
                        {
                            Console.WriteLine("\t" + menu[i]);
                        }
                    }
                }
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        choose--;
                        if (choose < 0)
                        {
                            choose = menu.Count - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        choose++;
                        if (choose > menu.Count - 1)
                        {
                            choose = 0;
                        }
                        break;
                }
                Console.Clear();
            }
            return choose;
        }
    }
}
