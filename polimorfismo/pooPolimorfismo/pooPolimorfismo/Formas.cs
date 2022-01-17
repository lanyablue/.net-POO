using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Formas
    {
        public Formas()
        {
            this.formaGeometrica = "";
            this.Base = 0;
            this.Altura = 0;
        }

        public Formas(String forma, Double Base, Double altura)
        {
            this.formaGeometrica = forma;
            this.Base = Base;
            this.Altura = altura;

        }
        
        
        
        public virtual String formaGeometrica { get; set; }
        public Double Base { get; set; }
        public Double Altura { get; set; }

        public virtual Double calcularArea()  // virtual para utilizar o polimorfismo
        {
            return 0;
        }




    }
}
