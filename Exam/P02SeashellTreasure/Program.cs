using System;
using System.Collections.Generic;

namespace P02SeashellTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] jaggedArray = new char[n][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                jaggedArray[row] = new char[inputNumbers.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = char.Parse(inputNumbers[col]);
                }
            }

            string input;

            List<char> collectedSeashells = new List<char>();

            int stolenSeashells = 0;

            while ((input = Console.ReadLine()) != "Sunset")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Collect":
                        int row = int.Parse(command[1]);

                        int col = int.Parse(command[2]);

                        CollectSeashells(jaggedArray, collectedSeashells, row, col);

                        break;
                    case "Steal":
                        row = int.Parse(command[1]);

                        col = int.Parse(command[2]);

                        string direction = command[3];

                        if (direction == "up")
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (row >= 0)
                                {
                                    stolenSeashells = StolSeashells(jaggedArray, stolenSeashells, row, col);
                                    row--;
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (row < jaggedArray.Length)
                                {
                                    stolenSeashells = StolSeashells(jaggedArray, stolenSeashells, row, col);
                                    row++;
                                }
                            }
                            
                        }
                        else if (direction == "left")
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (col >= 0)
                                {
                                    stolenSeashells = StolSeashells(jaggedArray, stolenSeashells, row, col);
                                    col--;
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (col < jaggedArray[row].Length)
                                {
                                    stolenSeashells = StolSeashells(jaggedArray, stolenSeashells, row, col);
                                    col++;
                                }
                            }
                        }

                        break;
                    default:
                        break;
                }
            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }

            if (collectedSeashells.Count > 0)
            {
                Console.WriteLine($"Collected seashells: {collectedSeashells.Count} -> {string.Join(", ", collectedSeashells)}");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {collectedSeashells.Count}");
            }

            Console.WriteLine($"Stolen seashells: {stolenSeashells}");
        }

        private static int StolSeashells(char[][] jaggedArray, int stolenSeashells, int row, int col)
        {
            if (IndexIsReal(jaggedArray, row, col))
            {
                if (jaggedArray[row][col] != '-')
                {
                    stolenSeashells++;
                    jaggedArray[row][col] = '-';
                }
            }

            return stolenSeashells;
        }

        private static void CollectSeashells(char[][] jaggedArray, List<char> collectedSeashells, int row, int col)
        {
            if (IndexIsReal(jaggedArray, row, col))
            {
                if (jaggedArray[row][col] != '-')
                {
                    collectedSeashells.Add(jaggedArray[row][col]);
                    jaggedArray[row][col] = '-';
                }
            }
        }

        private static bool IndexIsReal(char[][] jaggedArray, int row, int col)
        {
            bool result = jaggedArray.Length > row &&
                            jaggedArray[row].Length > col &&
                            row >= 0 &&
                            col >= 0;

            return result;
        }
    }
}
