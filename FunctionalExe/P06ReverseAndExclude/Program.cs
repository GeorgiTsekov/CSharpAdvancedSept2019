using System;
using System.Linq;

namespace P06ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse().Where(x => x % number != 0).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
