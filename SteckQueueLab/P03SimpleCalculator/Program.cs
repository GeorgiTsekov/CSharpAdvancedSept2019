using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(text.Reverse());

            while (stack.Count > 1)
            {
                int operator1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operator2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push($"{operator1 + operator2}");
                        break;
                    case "-":
                        stack.Push($"{operator1 - operator2}");
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
