using System;
using System.Collections.Generic;
using System.Linq;

namespace P04FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int lowerNumber = numbers[0];
            int upperNumber = numbers[1];

            List<int> numbersList = new List<int>();

            for (int i = lowerNumber; i <= upperNumber; i++)
            {
                numbersList.Add(i);
            }

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            if (command == "odd")
            {
                Console.WriteLine(string.Join(" ", numbersList
                    .Where(x => isOdd(x))));
            }
            else if (command == "even")
            {
                Console.WriteLine(string.Join(" ", numbersList
                    .Where(x => isEven(x))));
            }
        }
    }
}
