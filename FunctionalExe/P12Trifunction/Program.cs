using System;
using System.Linq;

namespace P12Trifunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLarger = (name, charsLenght) => name.Sum(x => x) >= charsLenght;

            Func<string[], Func<string, int, bool>, string> nameFilter =
                (inputNames, isLargerFilter) => inputNames.FirstOrDefault(x => isLargerFilter(x, number));

            string result = nameFilter(names, isLarger);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
