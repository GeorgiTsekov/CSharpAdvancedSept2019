using System;
using System.Collections.Generic;
using System.Text;

namespace P09SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "1":
                        stack.Push(text.ToString());
                        text.Append(command[1]);
                        break;
                    case "2":
                        int index = int.Parse(command[1]);
                        stack.Push(text.ToString());
                        text.Remove(text.Length - index, index);
                        break;
                    case "3":
                        index = int.Parse(command[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(stack.Pop());
                        break;
                }
            }
        }
    }
}
