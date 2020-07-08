using System;

namespace P02KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = x => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", x));

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(names);
        }
    }
}
