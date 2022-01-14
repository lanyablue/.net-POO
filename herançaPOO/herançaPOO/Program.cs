using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pergunta p =  new Pergunta();
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Quantos grammys a taylor tem?";
            p.Resposta = "10 grammys";
            p.Dica = "Procure na wikipedia";

            Console.WriteLine("Tente Adivinhar a pergunta: ");
            Console.WriteLine("Pergunta:  " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Resposta: ");
            String resposta = Console.ReadLine();


            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Você acertou!");
            } else
            {
                Console.WriteLine("Você errou!");
                Console.WriteLine("A resposta correta é: " + p.Resposta);
            }
            Console.ReadKey();
        }
    }
}
