using System;
using System.Collections.Generic;
using System.Text;

namespace P09PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Badges = 0;
            this.Name = name;
            pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
    }
}
