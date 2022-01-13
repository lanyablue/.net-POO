using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menssagem msg1, msg2;
            msg1 = new Menssagem();
            msg1.textoMenssagem = "Olá querida";
            msg1.exibirMensagem();

            msg2 = new Menssagem();
            msg2.textoMenssagem = "Buffo querida";
            msg2.exibirMensagem();

        }
    }
}
