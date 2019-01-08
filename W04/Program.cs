using System;
using System.Collections.Generic;

namespace W04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Folder> directory = new List<Folder>();
            for (int i = 0; i < 10; i++)
            {
                directory.Add(new Folder()
                {
                    Name = "Name: " + i,
                    Location = random.Next(100, 999).ToString(),
                    ModifyDate = new DateTime(random.Next(2018, 2019), random.Next(1, 12), random.Next(1, 28)),
                    Author = "Author " + random.Next(100, 999).ToString(),
                    Size = random.Next(0, 1000)
                });

            }

            Console.WriteLine("Before sorting");
            directory.PrintAll();

            directory.Sort();

            Console.WriteLine("After sorting");
            directory.PrintAll();

            Console.Read();
        }
    }
}
