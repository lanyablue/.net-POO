using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonAPP
{
    public class Pokedex
    {
        public Pokedex()
        { 
            this.inicilizarLista();
        }


        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return this.pokemons; }
        }


        private void inicilizarLista()
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonPlus>();

            PokemonPlus p = new PokemonPlus("Bulbasauro", "Tipo Planta", 20);
            this.pokemons.Add(p);

            p = new PokemonPlus("Charmander", "Tipo Fogo", 60);
            this.pokemons.Add(p);

            p = new PokemonPlus("jigglypuff", "Tipo Fada", 100);
            this.pokemons.Add(p);

            p = new PokemonPlus("Eevee", "Tipo Normal", 30);
            this.pokemons.Add(p);

            p = new PokemonPlus("Vaporeon", "Tipo Água", 75);
            this.pokemons.Add(p);

            p = new PokemonPlus("Espeon", "Tipo Psiquico", 95);
            this.pokemons.Add(p);

            p = new PokemonPlus("Umbreon", "Tipo Dark", 100);
            this.pokemons.Add(p);

            p = new PokemonPlus("Sylveon", "Tipo Fada", 65);
            this.pokemons.Add(p);

            p = new PokemonPlus("Jolteon", "Tipo Eletrico", 90);
            this.pokemons.Add(p);

            p = new PokemonPlus("Flareon", "Tipo Fogo", 70);
            this.pokemons.Add(p);

            p = new PokemonPlus("Leafeon", "Tipo Folha", 80);
            this.pokemons.Add(p);

            p = new PokemonPlus("Glaceon", "Tipo Gelo", 55);
            this.pokemons.Add(p);
        }


        public void listarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do pokémon: " + i);
                //this.Pokemons[i].ExibirDadosPokemon();
                Pokemon p = this.Pokemons[i];
                p.ExibirDadosPokemon();

            }
        }


    }
}
