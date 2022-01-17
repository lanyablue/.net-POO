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


        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }


        private void inicilizarLista()
        {
            // Instanciar a lista
            this.pokemons = new List<Pokemon>();

            Pokemon p = new Pokemon("Bulbasauro", "Tipo Planta");
            this.pokemons.Add(p);

            p = new Pokemon("Charmander", "Tipo Fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Mew", "Tipo lendario psiquico");
            this.pokemons.Add(p);

            p = new Pokemon("jigglypuff", "Tipo Fada");
            this.pokemons.Add(p);

            p = new Pokemon("Eevee", "Tipo Normal");
            this.pokemons.Add(p);

            p = new Pokemon("Vaporeon", "Tipo Água");
            this.pokemons.Add(p);

            p = new Pokemon("Espeon", "Tipo Psiquico");
            this.pokemons.Add(p);

            p = new Pokemon("Umbreon", "Tipo Dark");
            this.pokemons.Add(p);

            p = new Pokemon("Sylveon", "Tipo Fada");
            this.pokemons.Add(p);

            p = new Pokemon("Jolteon", "Tipo Eletrico");
            this.pokemons.Add(p);

            p = new Pokemon("Flareon", "Tipo Fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Leafeon", "Tipo Folha");
            this.pokemons.Add(p);

            p = new Pokemon("Glaceon", "Tipo Gelo");
            this.pokemons.Add(p);
        }


        public void listarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Pokemon p = this.Pokemons[i];
                p.ExibirDadosPokemon();

            }
        }


    }
}
