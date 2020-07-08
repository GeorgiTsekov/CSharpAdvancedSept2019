using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake<int> numbersInLake = new Lake<int>(numbers);

            Console.WriteLine(string.Join(", ", numbersInLake));
        }
    }
}
