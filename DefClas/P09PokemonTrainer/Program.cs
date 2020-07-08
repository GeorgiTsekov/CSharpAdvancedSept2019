using System;
using System.Collections.Generic;
using System.Linq;

namespace P09PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainer>();

            string command;

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] splitedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splitedCommand[0];
                string pokemonName = splitedCommand[1];
                string pokemonElement = splitedCommand[2];
                int pokemonHealth = int.Parse(splitedCommand[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                trainers[trainerName].Pokemons.Add(pokemon);
            }

            string element;

            while ((element = Console.ReadLine()) != "End")
            {
                CheckPokemonsForElement(trainers, element);
            }
            
            foreach (var trainer in trainers.OrderByDescending(b => b.Value.Badges))
            {
                Console.Write($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
                Console.WriteLine();
            }

        }

        private static void CheckPokemonsForElement(Dictionary<string, Trainer> trainers, string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Value.Pokemons.Any(x => x.Element == element))
                {
                    trainer.Value.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Value.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }

                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }
        }
    }
}
