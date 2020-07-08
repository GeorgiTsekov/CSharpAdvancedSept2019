using System;
using System.Linq;

namespace P02SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = arrayOfNumbers.Sum();
            int count = arrayOfNumbers.Count();

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
