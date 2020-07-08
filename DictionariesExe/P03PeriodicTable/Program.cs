using System;
using System.Collections.Generic;
using System.Linq;

namespace P03PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] chemicalElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var chemicalElement in chemicalElements)
                {
                    uniqueElements.Add(chemicalElement);
                }
            }

            var sortedElements = uniqueElements.OrderBy(x => x);

            Console.WriteLine(string.Join(" ", sortedElements));
        }
    }
}
