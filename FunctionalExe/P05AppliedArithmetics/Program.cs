using System;
using System.Linq;

namespace P05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> addByOne = x => x += 1;
            Func<int, int> multiplyByTwo = x => x *= 2;
            Func<int, int> substractByOne = x => x -= 1;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(addByOne).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiplyByTwo).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(substractByOne).ToArray();
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
