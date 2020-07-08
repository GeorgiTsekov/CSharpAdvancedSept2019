using System;
using System.Linq;

namespace P01DiagonalDiff
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size,size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sumFirst = 0;
            int sumSecond = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumFirst += matrix[i, i];
                sumSecond += matrix[i, size - 1 - i];
            }

            int result = Math.Abs(sumFirst - sumSecond);
            Console.WriteLine(result);
        }
    }
}
