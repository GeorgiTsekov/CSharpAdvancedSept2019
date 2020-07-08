using System;
using System.Linq;
using System.Collections.Generic;

namespace P08BalancedParantheses
{
    class Program
    {
        static void Main()
        {
            string symbols = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isValid = true;

            foreach (var symbol in symbols)
            {
                if (symbol == '{' || symbol == '(' || symbol == '[')
                {
                    stack.Push(symbol);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (symbol == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (symbol == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (symbol == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                }
            }

            if (isValid == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
