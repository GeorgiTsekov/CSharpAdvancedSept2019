using System;
using System.Collections.Generic;

namespace P06Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dictColorItems = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] colorItemsArray = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = colorItemsArray[0];
                string[] items = colorItemsArray[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!dictColorItems.ContainsKey(color))
                {
                    dictColorItems.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (!dictColorItems[color].ContainsKey(item))
                    {
                        dictColorItems[color].Add(item, 0);
                    }

                    dictColorItems[color][item]++;
                }
            }

            string[] colorAndClothing = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colorFound = colorAndClothing[0];
            string clothingFound = colorAndClothing[1];

            foreach (var keyValuePair in dictColorItems)
            {
                Console.WriteLine($"{keyValuePair.Key} clothes:");
                foreach (var item in keyValuePair.Value)
                {
                    if (item.Key == clothingFound && keyValuePair.Key == colorFound)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
