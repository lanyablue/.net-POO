using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançaPOO
{
    public class PerguntaPlus:Pergunta
    {
        public PerguntaPlus():base()
        {

            //this.testC = " ";  // quem herda consegue utilizar os dados protected
            this.Dica = " ";
        }

        public PerguntaPlus(String texto, String resposta, String dica):base(texto, resposta)
        {

            this.Dica = dica;
        }


        public string Dica { get; set; }

    }
}
