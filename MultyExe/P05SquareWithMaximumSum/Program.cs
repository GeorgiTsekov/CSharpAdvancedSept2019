using System;
using System.Linq;

namespace P05SquareWithMaximumSum
{
    class Program
    {
        static void Main()
        {
            int[] rowCol = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowCol[0], rowCol[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }
            int maxSum = int.MinValue;
            int maxIndexI = -1;
            int maxIndexJ = -1;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxIndexI,maxIndexJ]} "+ 
                $"{matrix[maxIndexI, maxIndexJ + 1]}\n" + 
                $"{matrix[maxIndexI + 1,maxIndexJ]} " + 
                $"{matrix[maxIndexI + 1, maxIndexJ + 1]}\n{maxSum}");
        }
    }
}
