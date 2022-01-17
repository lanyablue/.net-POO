using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Quadrado:Formas
    {
        public Quadrado():base()
        {
            base.formaGeometrica = "Quadrado";
        }

        public Quadrado(Double Base, Double altura):base("Quadrado", Base, altura)
        {

        }


        public override string formaGeometrica
        {
            get
            {
                return base.formaGeometrica;
            }
        }

        public String Teste { get; set; }

        public override Double calcularArea()  //sobrescrevendo o metodo que herdou da classe base
        {
            return this.Base * this.Altura;
        }
    }
}
