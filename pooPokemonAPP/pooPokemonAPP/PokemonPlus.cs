using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonAPP
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this.Poder = 0;
        }

        public PokemonPlus(String nome, String descricao, int poder) : base(nome, descricao)
        {
            this.Poder = poder;
        }


        public int Poder { get; set; }

        public void exibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Descrição: " + this.Descricao);
            Console.WriteLine("Poder: " + this.Poder);
        }



    }
}
