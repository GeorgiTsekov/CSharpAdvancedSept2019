using System;
using System.Collections.Generic;
using System.Linq;

namespace P04CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            int townsCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dictContCountryTowns = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < townsCount; i++)
            {
                string[] arrayOfContininents = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = arrayOfContininents[0];
                string country = arrayOfContininents[1];
                string town = arrayOfContininents[2];

                if (!dictContCountryTowns.ContainsKey(continent))
                {
                    dictContCountryTowns.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dictContCountryTowns[continent].ContainsKey(country))
                {
                    dictContCountryTowns[continent].Add(country, new List<string>());
                }

                dictContCountryTowns[continent][country].Add(town);
            }

            foreach (var item in dictContCountryTowns)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
