using System;
using System.Linq;

namespace P08Bombs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowsInMatrix = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowsInMatrix[j];
                }
            }

            string[] bombsArray = Console.ReadLine()
                    .Split(" ");

            int aliveCells = 0;
            int sum = 0;

            foreach (var item in bombsArray)
            {
                int[] splitedItem = item
                    .Split(",")
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = splitedItem[0];
                int secondIndex = splitedItem[1];
                if (matrix[firstIndex, secondIndex] <= 0)
                {
                    continue;
                }
                int bomb = matrix[firstIndex, secondIndex];

                matrix[firstIndex, secondIndex] = 0;

                if (secondIndex + 1 < size 
                    && matrix[firstIndex, secondIndex + 1] > 0)
                {
                    matrix[firstIndex, secondIndex + 1] -= bomb;
                }
                if (secondIndex - 1 >= 0 
                    && matrix[firstIndex, secondIndex - 1] > 0)
                {
                    matrix[firstIndex, secondIndex - 1] -= bomb;
                }
                if (firstIndex + 1 < size 
                    && matrix[firstIndex + 1, secondIndex] > 0)
                {
                    matrix[firstIndex + 1, secondIndex] -= bomb;
                }
                if (firstIndex - 1 >= 0 
                    && matrix[firstIndex - 1, secondIndex] > 0)
                {
                    matrix[firstIndex - 1, secondIndex] -= bomb;
                }
                if (firstIndex - 1 >= 0 
                    && secondIndex - 1 >= 0 
                    && matrix[firstIndex - 1, secondIndex - 1] > 0)
                {
                    matrix[firstIndex - 1, secondIndex - 1] -= bomb;
                }
                if (secondIndex + 1 < size 
                    && firstIndex + 1 < size 
                    && matrix[firstIndex + 1, secondIndex + 1] > 0)
                {
                    matrix[firstIndex + 1, secondIndex + 1] -= bomb;
                }
                if (firstIndex + 1 < size 
                    && secondIndex - 1 >= 0
                    && matrix[firstIndex + 1, secondIndex - 1] > 0)
                {
                    matrix[firstIndex + 1, secondIndex - 1] -= bomb;
                }
                if (firstIndex - 1 >= 0 
                    && secondIndex + 1 < size
                    && matrix[firstIndex - 1, secondIndex + 1] > 0)
                {
                    matrix[firstIndex - 1, secondIndex + 1] -= bomb;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        aliveCells++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
