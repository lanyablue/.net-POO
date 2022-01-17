using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonAPP
{
    public class Pokemon
    {
        public Pokemon()   // meu construtor
        {
            this.Nome = "";
            this.Descricao = "";

        }

        public Pokemon(String nome, String descricao)    // sobrecarregando o método
        {
            this.Nome = nome;
            this.Descricao = descricao;

        }


        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set {
                String texto = value.ToUpper();  // ações dentro do get e set
                this.nome = texto; 
                }
        }

        private String descricao; // armazena o valor da propriedade Descrição

        public String Descricao // representa a caracteristica Descrição do meu Pokemon
        {
            get { return this.descricao; }
            set { 
                this.descricao = value.ToUpper(); 
                }
        }


        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Descrição: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)  // sobrecarregando o metodo
        {
            if (formatado)
            {
                Console.WriteLine("Pokemon: " + this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {

            }
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Descrição: " + this.Descricao);
        }


    }
}
