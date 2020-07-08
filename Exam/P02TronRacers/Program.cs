using System;

namespace P02TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] squareMatrix = new char[n][];

            int firstPlayerRow = 0;
            int firstPlayerCol = 0;
            int secondPlayerRow = 0;
            int secondPlayerCol = 0;

            for (int i = 0; i < squareMatrix.Length; i++)
            {
                char[] array = Console.ReadLine().ToCharArray();
                squareMatrix[i] = new char[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    squareMatrix[i][j] = array[j];
                    if (array[j] == 'f')
                    {
                        firstPlayerRow = i;
                        firstPlayerCol = j;
                    }
                    else if (array[j] == 's')
                    {
                        secondPlayerRow = i;
                        secondPlayerCol = j;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "up":
                        firstPlayerRow--;
                        if (firstPlayerRow < 0)
                        {
                            firstPlayerRow = n - 1;
                        }
                        break;
                    case "down":
                        firstPlayerRow++;
                        if (firstPlayerRow == squareMatrix.Length)
                        {
                            firstPlayerRow = 0;
                        }
                        break;
                    case "left":
                        firstPlayerCol--;
                        if (firstPlayerCol < 0)
                        {
                            firstPlayerCol = n - 1;
                        }
                        break;
                    case "right":
                        firstPlayerCol++;
                        if (firstPlayerCol == squareMatrix[firstPlayerRow].Length)
                        {
                            firstPlayerCol = 0;
                        }
                        break;
                    default:
                        break;
                }

                if (squareMatrix[firstPlayerRow][firstPlayerCol] == 's')
                {
                    squareMatrix[firstPlayerRow][firstPlayerCol] = 'x';
                    break;
                }
                else
                {
                    squareMatrix[firstPlayerRow][firstPlayerCol] = 'f';
                }

                switch (command[1])
                {
                    case "up":
                        secondPlayerRow--;
                        if (secondPlayerRow < 0)
                        {
                            secondPlayerRow = n - 1;
                        }
                        break;
                    case "down":
                        secondPlayerRow++;
                        if (secondPlayerRow >= squareMatrix.Length)
                        {
                            secondPlayerRow = 0;
                        }
                        break;
                    case "left":
                        secondPlayerCol--;
                        if (secondPlayerCol < 0)
                        {
                            secondPlayerCol = n - 1;
                        }
                        break;
                    case "right":
                        secondPlayerCol++;
                        if (secondPlayerCol >= squareMatrix[secondPlayerRow].Length)
                        {
                            secondPlayerCol = 0;
                        }
                        break;
                    default:
                        break;
                }

                if (squareMatrix[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    squareMatrix[secondPlayerRow][secondPlayerCol] = 'x';
                    break;
                }
                else
                {
                    squareMatrix[secondPlayerRow][secondPlayerCol] = 's';
                }
            }

            for (int i = 0; i < squareMatrix.Length; i++)
            {
                for (int j = 0; j < squareMatrix[i].Length; j++)
                {
                    Console.Write(squareMatrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
