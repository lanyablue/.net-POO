using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançaPOO
{
    public class PerguntaPlus:Pergunta //herdou a classe pergunta
    {
        public PerguntaPlus():base()    //o contrutor exercuta primeiro o contrutor da classe mãe
        {

            //this.testC = " "; quem herda consegue utilizar os dados protected
            //this.testA = " "; 
            //this.testB = " "; não consegue acessar o privado atraves de herança

            this.Dica = " ";
        }

        public PerguntaPlus(String texto, String resposta, String dica):base(texto, resposta) //contrutor da classe base
        {

            this.Dica = dica;
        }


        public string Dica { get; set; }

    }
}
