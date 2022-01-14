using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercícioCalculoAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Animais a1 = new Animais();
            Animais a2 = new Animais();

            int quantCachorro = 0, quantGato = 0, quantPeixe = 0;

            // Primeiro animal
            Console.WriteLine("Controle de animais");
            Console.WriteLine("Informe o nome do animal:");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do animal (Gato, Cachorro ou Peixe):");
            a1.Tipo = Console.ReadLine();

            if (a1.Tipo == "Cachorro") quantCachorro++;
            if (a1.Tipo == "Gato") quantGato++;
            if (a1.Tipo == "Peixe") quantPeixe++;


            // Segundo animail
            Console.WriteLine("Controle de animais");
            Console.WriteLine("Informe o nome do animal:");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do animal (Gato, Cachorro ou Peixe):");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo == "Cachorro") quantCachorro++;
            if (a2.Tipo == "Gato") quantGato++;
            if (a2.Tipo == "Peixe") quantPeixe++;



            Console.WriteLine("Total de animais:");
            Console.WriteLine("Cachorros: " + quantCachorro);
            Console.WriteLine("Gatos: " + quantGato);
            Console.WriteLine("Peixes: " + quantPeixe);

            Console.ReadKey();


        }
    }
}
