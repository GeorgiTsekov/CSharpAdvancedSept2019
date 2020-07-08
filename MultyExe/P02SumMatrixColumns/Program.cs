using System;
using System.Linq;

namespace P02SumMatrixColumns
{
    class Program
    {
        static void Main()
        {
            int[] rowsCowsCount = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowsCowsCount[0], rowsCowsCount[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rows = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = rows[cow];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
