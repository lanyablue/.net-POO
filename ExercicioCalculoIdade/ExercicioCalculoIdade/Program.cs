using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Programa que Calcula a idade de uma pessoa: ");
                Pessoa p = new Pessoa();
                Console.WriteLine("Nome da pessoa: ");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Ano de nascimento: ");
                p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
                p.ExibirDados();
                Console.ReadKey();
            }

        }
    }
}
