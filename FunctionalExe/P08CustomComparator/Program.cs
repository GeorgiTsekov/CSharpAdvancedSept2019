using System;
using System.Linq;

namespace P08CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            numbers = numbers.OrderBy(x => x % 2 != 0).ThenBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
