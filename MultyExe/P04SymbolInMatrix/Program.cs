using System;
using System.Linq;
using System.Collections.Generic;

namespace P04SymbolInMatrix
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrixFromCharacters = new char[size, size];

            for (int i = 0; i < matrixFromCharacters.GetLength(0); i++)
            {
                char[] rows = Console.ReadLine()
                    .ToArray();
                for (int j = 0; j < matrixFromCharacters.GetLength(1); j++)
                {
                    matrixFromCharacters[i, j] = rows[j];
                }
            }

            char lastChar = char.Parse(Console.ReadLine());

            bool symbol = true;

            for (int i = 0; i < matrixFromCharacters.GetLength(0); i++)
            {
                for (int j = 0; j < matrixFromCharacters.GetLength(1); j++)
                {
                    if (matrixFromCharacters[i,j] == lastChar)
                    {
                        Console.WriteLine($"({i}, {j})");
                        symbol = false;
                        break;
                    }
                }
                if (symbol == false)
                {
                    break;
                }
            }
            if (symbol == true)
            {
                Console.WriteLine($"{lastChar} does not occur in the matrix");
            }
        }
    }
}
