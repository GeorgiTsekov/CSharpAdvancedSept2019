using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam23October2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] vegetables = new char[rows][];

            for (int i = 0; i < vegetables.Length; i++)
            {
                char[] arrayOfVegetables = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                vegetables[i] = new char[arrayOfVegetables.Length];

                for (int j = 0; j < arrayOfVegetables.Length; j++)
                {
                    vegetables[i][j] = arrayOfVegetables[j];
                }
            }

            string input;

            Dictionary<char, int> harvestVegetables = new Dictionary<char, int>();

            harvestVegetables.Add('C', 0);
            harvestVegetables.Add('P', 0);
            harvestVegetables.Add('L', 0);
            int harmedVegetables = 0;

            while ((input = Console.ReadLine()) != "End of Harvest")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Harvest":
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);

                        if (vegetables.Length > row && 
                            row >= 0 && 
                            vegetables[row].Length > col && 
                            col >= 0)
                        {
                            char vegetable = vegetables[row][col];

                            if (harvestVegetables.ContainsKey(vegetable))
                            {
                                harvestVegetables[vegetable]++;
                                vegetables[row][col] = ' ';
                            }
                        }
                        break;
                    case "Mole":
                        row = int.Parse(command[1]);
                        col = int.Parse(command[2]);
                        string direction = command[3].ToLower();

                        while (vegetables.Length > row &&
                            row >= 0 &&
                            vegetables[row].Length > col && 
                            col >= 0)
                        {
                            char vegetable = vegetables[row][col];

                            if (harvestVegetables.ContainsKey(vegetable))
                            {
                                harmedVegetables++;
                                vegetables[row][col] = ' ';
                            }

                            switch (direction)
                            {
                                case "up":
                                    row -= 2;
                                    break;
                                case "down":
                                    row += 2;
                                    break;
                                case "left":
                                    col -= 2;
                                    break;
                                case "right":
                                    col += 2;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            
            for (int i = 0; i < vegetables.Length; i++)
            {
                for (int j = 0; j < vegetables[i].Length; j++)
                {
                    Console.Write($"{vegetables[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Carrots: {harvestVegetables['C']}");
            Console.WriteLine($"Potatoes: {harvestVegetables['P']}");
            Console.WriteLine($"Lettuce: {harvestVegetables['L']}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }
    }
}
