using System;
using System.Collections.Generic;
using System.Linq;

namespace P01ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            string command;

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        var result = listyIterator.Move();
                        Console.WriteLine(result);
                        break;
                    case "HasNext":
                        result = listyIterator.HasNext();
                        Console.WriteLine(result);
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        foreach (var element in listyIterator)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
