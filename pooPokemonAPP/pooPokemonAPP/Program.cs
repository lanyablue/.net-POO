using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.listarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.listarPokemons();
                    Console.WriteLine("Digite o código do pokémon escolhido: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    // Definior o pokemon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];

                    // Definir o pokemon do PC
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];

                    // Batalha

                    Console.WriteLine("Seu pokemon: ");
                    pPlayer.exibirDadosPokemonPlus();
                   
                    Console.WriteLine("Poder do pokmon adversário: ");
                    pPC.exibirDadosPokemonPlus();

                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Paranbéns!!! Você ganhou!!!");
                    } 
                    else
                    {
                        Console.WriteLine("Você Perdeu!!!!");
                    }

                   

                }
                Console.ReadKey();
                Console.Clear();
            }
            


            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokemon-------Jogo de batalha");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Listar todos os pokemons da pokedex");
            Console.WriteLine("2 - Batalhar");

            Console.WriteLine("O que deseja: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }

    }
}
