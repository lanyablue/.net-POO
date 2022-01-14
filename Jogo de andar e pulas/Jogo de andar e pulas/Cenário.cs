using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_andar_e_pulas
{
    class Cenário
    {
        public String Chao { set; get; }
        public Byte Tamanho { set; get; }


        public Cenário(String Chao, Byte tamanho)
        {
            this.Chao = Chao;
            this.Tamanho = tamanho;

        }


        public void imprime(Player p)
        {
            Console.Clear();
            Console.WriteLine();

            // Imprimi a primeira linha
            if (p.Pulando)
            {
                for (Byte i = 0; i < p.Posição; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Aparência);
            }

            else
            {
                Console.WriteLine();
            }

            // Imprimindo segunda linha

            for (Byte i = 0; i < p.Posição; i++)
            {
               
                Console.Write(Chao);
            }

            if (p.Pulando)
            {
                Console.Write(Chao);
            }
            else
            {
                Console.Write(p.Aparência);
            }

            for (Byte i = 0; i < (Tamanho - p.Posição); i++)
            {
                Console.Write(Chao);
            }

        }
    }

}
