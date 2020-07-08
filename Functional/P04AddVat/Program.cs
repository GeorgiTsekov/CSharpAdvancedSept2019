using System;
using System.Linq;

namespace P04AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var item in arrayOfNumbers)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
