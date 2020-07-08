using System;
using System.Linq;
using System.Collections.Generic;

namespace P01CountSameValuesInArray
{
    class Program
    {
        static void Main()
        {
            double[] arrayOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> repeatedKeys = new Dictionary<double, int>();

            foreach (var number in arrayOfNumbers)
            {
                if (!repeatedKeys.ContainsKey(number))
                {
                    repeatedKeys.Add(number, 0);
                }

                repeatedKeys[number]++;
            }

            foreach (var item in repeatedKeys)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
