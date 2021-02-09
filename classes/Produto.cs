using System;
using Metodos_Construtores.classes;

namespace Metodos_Construtores.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        public int Estoque { get; set; }  

        //método construtor
        public Produto()
        {
            Console.WriteLine("Método construtor foi executado");
        }  
        public Produto(int valor)
        {
            Codigo = valor;
            Console.WriteLine($"Código inserido foi {Codigo}");
        }

        // public string ExibeTexto()
        // {
        //     return "Esse método exibe o texto Carlos";
        // }

        // public string ExibeTexto(string nome)
        // {
        //     return $"Esse método exibe o texto {nome}";
        // }

        public Produto(int codigo, string nome, string descricao, int estoque)
        {
            //o maiúsculo é o atributo da classe
            //o minúsculo é o que está dentro do parâmetro do método
            Codigo    = codigo;
            Nome      = nome;
            Descricao = descricao;
            Estoque   = estoque;
        }
    }
}