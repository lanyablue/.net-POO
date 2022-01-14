using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercícioCalculoAnimais
{
    internal class Animais
    {
        private String nome;
        private String tipo;


        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }


        public String Tipo
        {
            get { return this.tipo; }
            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    this.tipo = value;
                }
                else
                {
                    this.tipo = "Peixe";
                }
            }
        }



        }
}
