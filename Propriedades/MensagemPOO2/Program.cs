using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Menssagem
    {
        //    private String TextoMenssagem;



        //    public void exibirMensagem()
        //    {
        //        Console.WriteLine(this.TextoMenssagem);
        //    }

        //    public string gettextoMensagem()
        //    {
        //        return this.TextoMenssagem;
        //    }

        //    public void setextoMensagem(String valor)
        //    {
        //        this.TextoMenssagem = valor;
        //    }


        private String textoMensagem;

        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }

        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

    }
}

