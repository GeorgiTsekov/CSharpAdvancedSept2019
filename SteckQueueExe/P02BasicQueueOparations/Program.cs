using System;
using System.Collections.Generic;
using System.Linq;

namespace P02BasicQueueOparations
{
    class Program
    {
        static void Main()
        {
            int[] nSAndX = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            int n = nSAndX[0];
            int s = nSAndX[1];
            int x = nSAndX[2];

            if (queue.Count == n)
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Min());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
