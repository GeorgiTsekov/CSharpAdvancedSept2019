using System;
using System.Collections.Generic;
using System.Linq;

namespace P01ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<int> integers = new List<int>();
            Queue<string> halls = new Queue<string>();
            int safeCapacity = capacity;

            Stack<string> elements = new Stack<string>(input);

            while (elements.Count > 0)
            {
                string currentElement = elements.Pop();

                bool isNumber = int.TryParse(currentElement, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
                else
                {
                    if (safeCapacity - parsedNumber < 0 && halls.Count > 0)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> " + string.Join(", ", integers));
                        integers.Clear();
                        safeCapacity = capacity;
                        if (halls.Count > 0)
                        {
                            safeCapacity -= parsedNumber;
                            integers.Add(parsedNumber);
                        }
                    }
                    else if (safeCapacity - parsedNumber >= 0 && halls.Count > 0)
                    {
                        integers.Add(parsedNumber);
                        safeCapacity -= parsedNumber;
                    }
                }
            }
        }
    }
}
