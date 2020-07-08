using System;
using System.Collections.Generic;
using System.Linq;

namespace P02StackSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            Stack<int> stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] splitedInput = input.ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (splitedInput[0])
                {
                    case "add":
                        for (int i = 1; i < splitedInput.Length; i++)
                        {
                            stack.Push(int.Parse(splitedInput[i]));
                        }
                        break;
                    case "remove":
                        int index = int.Parse(splitedInput[1]);
                        if (stack.Count > index)
                        {
                            for (int i = 0; i < index; i++)
                            {
                                stack.Pop();
                            }
                        }                      
                        break;
                }
            }

            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
