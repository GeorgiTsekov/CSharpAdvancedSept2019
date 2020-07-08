using System;
using System.Linq;

namespace P03MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] rowsCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowsCols[0], rowsCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }
            int maxSum = int.MinValue;
            int row = -1;
            int col = -1;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                int sum = 0;

                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                }             
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}");
            Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}");
            Console.WriteLine($"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
        }
    }
}
