using System;
using System.Linq;

namespace P07KnightGame
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rowArray = Console.ReadLine()
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowArray[j];
                }
            }
            int counter = 0;

            while (true)
            {
                int maxKnightMoves = 0;

                int row = -1;

                int col = -1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int knightMoves = 0;

                        if (matrix[i, j] == 'K')
                        {
                            if (matrix.GetLength(0) > i + 1
                                && matrix.GetLength(1) > j + 2
                                && matrix[i + 1, j + 2] == 'K')
                            {
                                knightMoves++;
                            }
                            if (matrix.GetLength(0) > i + 2
                                && matrix.GetLength(1) > j + 1
                                && matrix[i + 2, j + 1] == 'K')
                            {
                                knightMoves++;
                            }
                            if (matrix.GetLength(0) > i + 1
                                && j - 2 >= 0
                                && matrix[i + 1, j - 2] == 'K')
                            {
                                knightMoves++;
                            }
                            if (matrix.GetLength(0) > i + 2
                                && j - 1 >= 0
                                && matrix[i + 2, j - 1] == 'K')
                            {
                                knightMoves++;
                            }
                            if (i - 1 >= 0
                               && j - 2 >= 0
                               && matrix[i - 1, j - 2] == 'K')
                            {
                                knightMoves++;
                            }
                            if (i - 1 >= 0
                               && matrix.GetLength(1) > j + 2
                               && matrix[i - 1, j + 2] == 'K')
                            {
                                knightMoves++;
                            }
                            if (i - 2 >= 0
                              && matrix.GetLength(1) > j + 1
                              && matrix[i - 2, j + 1] == 'K')
                            {
                                knightMoves++;
                            }
                            if (i - 2 >= 0
                              && j - 1 >= 0
                              && matrix[i - 2, j - 1] == 'K')
                            {
                                knightMoves++;
                            }
                        }
                        if (knightMoves > maxKnightMoves)
                        {
                            maxKnightMoves = knightMoves;
                            row = i;
                            col = j;
                        }
                    }
                }
                if (maxKnightMoves > 0)
                {
                    matrix[row, col] = '0';
                    counter++;
                }
                else
                {
                    break;
                }
            }
         
            Console.WriteLine(counter);
        }
    }
}
