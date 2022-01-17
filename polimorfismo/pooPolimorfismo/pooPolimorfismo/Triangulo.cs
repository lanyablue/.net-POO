using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Triangulo:Formas
    {
        public Triangulo():base()
        {
            base.formaGeometrica = "Triângulo";
        }

        public Triangulo(double Base, double altura):base("Triângulo", Base, altura)
        {


        }

        public override string formaGeometrica 
        {
            get
            {
                return base.formaGeometrica;
            }

        }

        public override double calcularArea()
        {
            return this.Base * this.Altura / 2;
        }

    }
}
