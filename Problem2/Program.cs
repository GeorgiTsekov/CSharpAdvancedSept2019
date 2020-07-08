using System;

namespace P03SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];

            int row = 0;

            int col = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];
                    if (line[j] == 'S')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            int stars = 0;

            bool indexIsOutsideOfRange = false;

            while (stars < 50 && !indexIsOutsideOfRange)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        matrix[row, col] = '-';

                        row--;
                        if (row < 0)
                        {
                            indexIsOutsideOfRange = true;
                            break;
                        }
                        break;
                    case "down":
                        matrix[row, col] = '-';

                        row++;
                        if (row >= matrix.GetLength(1))
                        {
                            indexIsOutsideOfRange = true;
                            break;
                        }
                        break;
                    case "left":
                        matrix[row, col] = '-';

                        col--;
                        if (col < 0)
                        {
                            indexIsOutsideOfRange = true;
                            break;
                        }
                        break;
                    case "right":
                        matrix[row, col] = '-';

                        col++;
                        if (col >= matrix.GetLength(1))
                        {
                            indexIsOutsideOfRange = true;
                            break;
                        }
                        break;
                }

                if (indexIsOutsideOfRange)
                {
                    break;
                }

                char element = matrix[row, col];

                if (char.IsDigit(element))
                {
                    int digit = int.Parse(element.ToString());
                    stars += digit;
                    matrix[row, col] = 'S';
                }
                else if (element == 'O')
                {
                    matrix[row, col] = '-';

                    bool indexIsO = false;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == 'O')
                            {
                                row = i;
                                col = j;
                                matrix[row, col] = 'S';
                                indexIsO = true;
                                break;
                            }
                        }

                        if (indexIsO)
                        {
                            break;
                        }
                    }
                }
            }

            if (stars >= 50)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {stars}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
