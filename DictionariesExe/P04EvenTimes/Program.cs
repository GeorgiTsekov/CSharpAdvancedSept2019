using System;
using System.Collections.Generic;
using System.Linq;

namespace P04EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                else
                {
                    numbers[number]++;
                }
            }
            var numbs = numbers.Where(y => y.Value % 2 != 0);

            foreach (var item in numbs)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
