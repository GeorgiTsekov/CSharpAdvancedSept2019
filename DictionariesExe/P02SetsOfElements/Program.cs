using System;
using System.Collections.Generic;
using System.Linq;

namespace P02SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] twoNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstNumber = twoNumbers[0];
            int secondNumber = twoNumbers[1];

            HashSet<int> firstNumbers = new HashSet<int>();

            HashSet<int> uniqueNumbers = new HashSet<int>();

            for (int i = 0; i < firstNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstNumbers.Add(number);
            }

            for (int i = 0; i < secondNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (firstNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueNumbers));
        }
    }
}
