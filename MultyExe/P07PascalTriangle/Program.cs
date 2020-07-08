using System;
using System.Linq;

namespace P07PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[size][];

            int cols = 1;

            for (int i = 0; i < size; i++)
            {
                pascalTriangle[i] = new long[cols];
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][cols - 1] = 1;

                if (cols > 2)
                {
                    long[] previousRow = pascalTriangle[i - 1];

                    for (int j = 1; j < cols - 1; j++)
                    {
                        pascalTriangle[i][j] = previousRow[j] + previousRow[j - 1];
                    }
                }

                cols++;
            }

            foreach (var item in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
