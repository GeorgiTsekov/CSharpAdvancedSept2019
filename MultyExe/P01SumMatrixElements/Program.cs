using System;
using System.Linq;

namespace P01SumMatrixElements
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCows = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] arr = new int[rowsAndCows[0],rowsAndCows[1]];

            int sum = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int cow = 0; cow < arr.GetLength(1); cow++)
                {
                    arr[row, cow] = tokens[cow];
                    sum += tokens[cow];
                }
            }

            Console.WriteLine(rowsAndCows[0]);
            Console.WriteLine(rowsAndCows[1]);
            Console.WriteLine(sum);
        }
    }
}
