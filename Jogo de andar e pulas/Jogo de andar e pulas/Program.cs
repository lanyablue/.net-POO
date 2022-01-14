using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_andar_e_pulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("=>", "<=");
            Cenário c = new Cenário("_", 60);
            ConsoleKey tecla;

            c.imprime(p);

            do
            {
                tecla = Console.ReadKey().Key;

                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        // ANDAR PARA TRAS
                        p.andar(false, c.Tamanho);
                        c.imprime(p);
                        break;

                    case ConsoleKey.RightArrow:
                        // ANDAR PRA FRENTE
                        p.andar(true, c.Tamanho);
                        c.imprime(p);
                        break;

                    case ConsoleKey.UpArrow:
                        // Pular
                        p.Pulando = true;
                        c.imprime(p);
                        p.pular();
                        p.Pulando = false;
                        c.imprime(p);
                        break;

                    default:
                        c.imprime(p);
                        break;
                    }
                } while (tecla != ConsoleKey.Escape) ;

        }
    }
}

