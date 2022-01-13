using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoIdade
{
    public class Pessoa
    {
        private int anoNascimento;
        public int AnoNascimento
        {

            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }

        }


        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        //Melhorando o código

        private int idade;

        public int Idade
        {
            get { 
                this.CalcularIdade();
                return this.idade; 
                }

        }


        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Ano de nascimento: " + anoNascimento);
            this.CalcularIdade();   
            Console.WriteLine("Idade:  " + this.Idade);
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.anoNascimento;
            
        }
    }
}
