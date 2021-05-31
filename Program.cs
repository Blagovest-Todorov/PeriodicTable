using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
           // string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int inputLines = int.Parse(Console.ReadLine());

            if (inputLines <= 0)
            {
                Environment.Exit(1);
            }

            FillSortedSet(elements, inputLines);

            if (elements.Count != 0)
            {
                PrintSortedSet(elements);
            }   
        }

        private static void PrintSortedSet(SortedSet<string> elements)
        {
            Console.WriteLine(string.Join(" ", elements ));
        }

        private static void FillSortedSet(SortedSet<string> elements, int numberLines)
        {
            for (int i = 0; i < numberLines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line.Length <= 0)
                {
                    continue;
                }

                foreach (var item in line)
                {
                    elements.Add(item);
                }
            }
        }
    }
}
