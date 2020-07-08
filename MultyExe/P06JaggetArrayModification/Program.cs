using System;
using System.Linq;

namespace P06JaggetArrayModification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggetArray = new int[rows][];

            for (int i = 0; i < jaggetArray.Length; i++)
            {
                int[] arrayOfNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggetArray[i] = arrayOfNumbers;
            }
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (splitedInput[0])
                {
                    case "Add":
                        int row = int.Parse(splitedInput[1]);
                        int col = int.Parse(splitedInput[2]);
                        int number = int.Parse(splitedInput[3]);
                        if (row < 0
                            || col < 0
                            || row >= jaggetArray.Length
                            || col >= jaggetArray[row].Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }
                        else
                        {
                            jaggetArray[row][col] += number;
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(splitedInput[1]);
                        col = int.Parse(splitedInput[2]);
                        number = int.Parse(splitedInput[3]);
                        if (row < 0
                            || col < 0
                            || row >= jaggetArray.Length
                            || col >= jaggetArray[row].Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }
                        else
                        {
                            jaggetArray[row][col] -= number;
                        }
                        break;
                }
            }

            foreach (var item in jaggetArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}