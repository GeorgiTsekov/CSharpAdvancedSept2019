using System;
using System.Collections.Generic;
using System.Linq;

namespace P09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            int[] dividerNumbers = Enumerable.Range(1, number).ToArray();           

            for (int i = 1; i <= number; i++)
            {
                foreach (var item in numbers)
                {
                    predicates.Add(x => x % item == 0);
                }
            }

            Console.WriteLine(string.Join(" ", predicates));
        }
    }
}
