using System;
using System.Collections.Generic;
using System.Linq;

namespace P01SummerCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredients = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] freshness = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            Dictionary<string, int> coctails = new Dictionary<string, int>();

            coctails.Add("Mimosa", 0);
            coctails.Add("Daiquiri", 0);
            coctails.Add("Sunshine", 0);
            coctails.Add("Mojito", 0);

            int ingredientsLeft = 0;

            int zeroCounter = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != 0)
                {
                    if (i - zeroCounter < freshness.Length)
                    {
                        int multiply = ingredients[i] * freshness[i - zeroCounter];

                        if (multiply == 150)
                        {
                            coctails["Mimosa"]++;
                        }
                        else if (multiply == 250)
                        {
                            coctails["Daiquiri"]++;
                        }
                        else if (multiply == 300)
                        {
                            coctails["Sunshine"]++;
                        }
                        else if (multiply == 400)
                        {
                            coctails["Mojito"]++;
                        }
                        else
                        {
                            ingredientsLeft += ingredients[i] + 5;
                        }
                    }
                    else
                    {
                        ingredientsLeft += ingredients[i];
                    }
                }
                else
                {
                    zeroCounter++;
                }
            }

            var realCoctailsOnly = coctails.Where(x => x.Value > 0).OrderBy(x => x.Key);

            if (realCoctailsOnly.Count() == 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            if (ingredientsLeft > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientsLeft}");
            }

            foreach (var coctail in realCoctailsOnly)
            {
                Console.WriteLine($" # {coctail.Key} --> {coctail.Value}");
            }
        }
    }
}
