using System;
using System.Linq;

namespace P09Miner
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[size, size];

            int row = -1;
            int col = -1;
            int maxCoals = 0;

            for (int i = 0; i < size; i++)
            {
                char[] characters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    field[i, j] = characters[j];
                    if (field[i, j] == 's')
                    {
                        row = i;
                        col = j;
                    }
                    if (field[i, j] == 'c')
                    {
                        maxCoals++;
                    }
                }
            }

            int coals = 0;
            foreach (var command in commands)
            {
                char nextChar = field[row, col];

                switch (command)
                {
                    case "left":
                        if (col - 1 >= 0)
                        {
                            col = col - 1;
                            nextChar = field[row, col];
                        }
                        break;
                    case "right":
                        if (col + 1 < size)
                        {
                            col = col + 1;
                            nextChar = field[row, col];
                        }
                        break;
                    case "down":
                        if (row + 1 < size)
                        {
                            row = row + 1;
                            nextChar = field[row, col];
                        }
                        break;
                    case "up":
                        if (row - 1 >= 0)
                        {
                            row = row - 1;
                            nextChar = field[row, col];
                        }
                        break;
                    default:
                        break;
                }

                if (nextChar == 'c')
                {
                    field[row, col] = '*';
                    coals++;
                    nextChar = '*';
                    if (coals == maxCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({row}, {col})");
                        return;
                    }
                }
                else if (nextChar == 'e')
                {
                    Console.WriteLine($"Game over! ({row}, {col})");
                    return;
                }
            }

            Console.WriteLine($"{maxCoals - coals} coals left. ({row}, {col})");
        }
    }
}
