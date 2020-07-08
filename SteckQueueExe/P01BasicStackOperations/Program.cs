using System;
using System.Collections.Generic;
using System.Linq;

namespace P01BasicStackOperations
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

            Stack<int> stack = new Stack<int>(numbers);

            int n = nSAndX[0];
            int s = nSAndX[1];
            int x = nSAndX[2];
            
            if (stack.Count == n)
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                }
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }

        }
    }
}
