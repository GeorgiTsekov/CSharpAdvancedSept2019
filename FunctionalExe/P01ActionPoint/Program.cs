using System;

namespace P01ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(names);
        }
    }
}
