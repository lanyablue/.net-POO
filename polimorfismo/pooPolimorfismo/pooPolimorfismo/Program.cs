using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado(2, 2);
            Quadrado q2 = new Quadrado(6, 6);
            Quadrado q3 = new Quadrado(7, 7);
            Console.WriteLine(q1.formaGeometrica);
            Console.WriteLine(q1.calcularArea());

            Triangulo t1 = new Triangulo(5, 3);
            Triangulo t2 = new Triangulo(6, 3);
            Triangulo t3 = new Triangulo(2, 3);
            Console.WriteLine(t1.formaGeometrica);
            Console.WriteLine(t1.calcularArea());


            List<Formas> Formas = new List<Formas>();
            Formas.Add(q1);
            Formas.Add(q2);
            Formas.Add(q3);
            Formas.Add(t1);
            Formas.Add(t2);
            Formas.Add(t3);

            foreach (var item in Formas)
            {
                Console.WriteLine("Tipo da forma: " + item.formaGeometrica);
                Console.WriteLine("Base: " + item.Base);
                Console.WriteLine("Altura: " + item.Altura);
                Console.WriteLine("Area: " + item.calcularArea());
            }

            exibirTipo(q1);

            Console.ReadKey();
        }


        static void exibirTipo(Formas forma)
        {
            Quadrado q = (Quadrado)forma;
            q.Teste = "manu gavassi rainha do pop";
            Console.WriteLine(q.Teste);
            Console.WriteLine("Tipo da forma: " + forma.formaGeometrica);

        }
    }
}
