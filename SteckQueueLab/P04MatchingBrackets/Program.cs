using System;
using System.Collections.Generic;

namespace P04MatchingBrackets
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push(i);
                }
                else if (text[i] == ')')
                {
                    Console.WriteLine(text.Substring(stack.Peek(), i - stack.Peek() + 1));
                    stack.Pop();
                }
            }
        }
    }
}
