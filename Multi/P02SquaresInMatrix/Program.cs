using System;
using System.Linq;

namespace P02SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[rowsAndCols[0],rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i,j] == matrix[i, j + 1] 
                        && matrix[i + 1, j] == matrix[i + 1, j + 1]
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
