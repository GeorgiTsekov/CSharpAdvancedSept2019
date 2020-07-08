using System;
using System.Collections.Generic;

namespace P01ReverseString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
