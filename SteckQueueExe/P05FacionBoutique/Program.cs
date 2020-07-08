using System;
using System.Linq;
using System.Collections.Generic;

namespace P05FacionBoutique
{
    class Program
    {
        static void Main()
        {
            int[] boxes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(boxes);

            int sum = 0;

            int boxesCount = 1;

            for (int i = 0; i < boxes.Length; i++)
            {
                sum += stack.Peek();
                if (sum > capacity)
                {
                    sum = 0;
                    i--;
                    boxesCount++;
                }
                else if (sum == capacity && i < boxes.Length - 1)
                {
                    sum = 0;
                    stack.Pop();
                    boxesCount++;
                }
                else if (sum < capacity)
                {
                    stack.Pop();
                }
            }
            
            Console.WriteLine(boxesCount);
        }
    }
}
