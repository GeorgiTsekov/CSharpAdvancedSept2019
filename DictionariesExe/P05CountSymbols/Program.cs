using System;
using System.Collections.Generic;
using System.Linq;

namespace P05CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (!characters.ContainsKey(character))
                {
                    characters.Add(character, 0);
                }

                characters[character]++;
            }

            foreach (var character in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
