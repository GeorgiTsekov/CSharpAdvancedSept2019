using System;
using System.Linq;
using System.Collections.Generic;

namespace P05PrintEvenNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Queue<int> queque = new Queue<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    queque.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", queque));
        }
    }
}
