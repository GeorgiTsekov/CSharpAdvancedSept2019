using System;
using System.Collections.Generic;
using System.Linq;

namespace P03Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            CustumStack<int> elements = new CustumStack<int>();

            while ((command != "END"))
            {
                if (command.Contains("Push"))
                {
                    string[] splitedCommand = command.Split(", ");
                    string firstElement = string.Empty;
                    foreach (var character in splitedCommand[0])
                    {
                        if (char.IsDigit(character))
                        {
                            firstElement += character;
                        }
                    }
                    int firstNumber = int.Parse(firstElement);

                    elements.Elements.Push(firstNumber);

                    for (int i = 1; i < splitedCommand.Length; i++)
                    {
                        int element = int.Parse(splitedCommand[i]);
                        elements.Elements.Push(element);
                    }
                }
                else if (command.Contains("Pop"))
                {
                    if (elements.Elements.Count > 0)
                    {
                        elements.Elements.Pop();
                    }
                    else
                    {
                        Console.WriteLine("No elements");
                    }
                }
                
                command = Console.ReadLine();
            }

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
