using System;
using System.Linq;
using System.Collections.Generic;

namespace P04FastFood
{
    class Program
    {
        static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            Queue<int> leftQueue = new Queue<int>();

            foreach (var order in orders)
            {
                if (queue.Sum() <= quantity)
                {
                    queue.Enqueue(order);
                    if (queue.Sum() > quantity)
                    {
                        leftQueue.Enqueue(order);
                    }
                }
                else
                {
                    leftQueue.Enqueue(order);
                }
            }
            Console.WriteLine(queue.Max());
            if (leftQueue.Count <= 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", leftQueue)}");
                return;
            }
        }
    }
}
