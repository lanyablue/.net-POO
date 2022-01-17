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
                Console.ReadKey();
                Console.Clear();
            }
            


            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokedex-------Agenda Pokemon");
            Console.WriteLine("0 - Sair da pokedex");
            Console.WriteLine("1 - Listar todos os pokemons");

            Console.WriteLine("O que deseja: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }

    }
}
