using System;
using System.Linq;

namespace P03PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[size, size];

            for (int i = 0; i < squareMatrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < squareMatrix.GetLength(1); j++)
                {
                    squareMatrix[i, j] = row[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < squareMatrix.GetLength(0); i++)
            {
                sum += squareMatrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
