using System;
using System.Linq;

namespace W10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Words start with A or a:");
            string[] words = { "cherry", "apple", "blueberry", "banana", "orange", "raspberry", "strawberry", "mango", "grape", "papaya", "watermelon", "melon", "avocados" };
            (
                from word in words
                where word.ToLower().StartsWith("a")
                select word
                )
                .ToList()
                .ForEach((word) =>
                {
                    Console.WriteLine("\t" + word);
                });
            Console.WriteLine("Words have 4 characters:");

            (
                from word in words
                where word.Length == 4
                select word
                )
                .ToList()
                .ForEach((word) =>
                {
                    Console.WriteLine("\t" + word);
                });

            Console.WriteLine("Sum of character number: ");
            Console.WriteLine((from word in words select word.Length).Sum());

            (
                from word in words
                group word by word.Length into wordByLength
                select new
                {
                    Length = wordByLength.Key,
                    Words = wordByLength,
                    MaxLength = (from word in words select word.Length).Max(),
                    MinLength = (from word in words select word.Length).Min()
                }).ToList().ForEach((group) =>
                {
                    bool show = false;
                    if (group.Length == group.MinLength)
                    {
                        Console.WriteLine("Smallest words: ");
                        show = true;

                    }
                    else if (group.Length == group.MaxLength)
                    {
                        Console.WriteLine("Largest words: ");
                        show = true;
                    }
                    if (show)
                    {
                        group.Words.ToList().ForEach((word) =>
                        {
                            Console.WriteLine("\t" + word);
                        });
                    }

                });

            Console.WriteLine("Grouping by length");
            (
             from word in words
             group word by word.Length into wordGroup
             orderby wordGroup.Key
             select new { Length = wordGroup.Key, Group = wordGroup }
             )
             .ToList()
             .ForEach((group) =>
             {
                 Console.WriteLine(group.Length + ": " + group.Group.ToList().Count + " word(s): ");
                 group.Group.ToList().ForEach((word) =>
                 {
                     Console.WriteLine("\t" + word);
                 });

             });
            Console.Read();

        }
    }
}
