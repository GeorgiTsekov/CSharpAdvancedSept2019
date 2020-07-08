using System;
using System.Collections.Generic;

namespace P08TrafficJam
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string input;

            int count = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            count++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }                        
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
