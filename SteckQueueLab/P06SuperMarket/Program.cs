using System;
using System.Collections.Generic;

namespace P06SuperMarket
{
    class Program
    {
        static void Main()
        {
            string input;

            Queue<string> peopleRemaining = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    int n = peopleRemaining.Count;
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{peopleRemaining.Dequeue()}");
                    }
                }
                else
                {
                    peopleRemaining.Enqueue(input);
                }
            }

            Console.WriteLine($"{peopleRemaining.Count} people remaining.");
        }
    }
}
