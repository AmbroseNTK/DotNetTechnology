using System;
using System.Collections.Generic;
using System.Text;

namespace W04
{
    public static class MyExtensions
    {
        public static void PrintAll<T>(this List<T> list)
        {
            foreach (T element in list)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
