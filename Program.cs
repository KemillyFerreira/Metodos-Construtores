using System;
using Metodos_Construtores.classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(10);

            //o método construtor sempre será executado quando instanciado o objeto
            // Console.WriteLine(produto.ExibeTexto());

            //utilizando o construtor vazio
            Produto produto1    = new Produto();
            produto1.Codigo     = 1;
            produto1.Nome       = "Coca-Cola";
            produto1.Descricao  = "Refrigerante de cola";
            produto1.Estoque    = 30;

            Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");

            //construtor inserindo apenas o código
            Produto produto2 = new Produto(10);

            produto2.Nome = "Pepsi";

            Console.WriteLine($"Codigo inserido {produto2.Codigo}, nome {produto2.Nome}");

            //construtor inserindo todos os valores
            Produto produto3 = new Produto(1, "Trakinas", "Bolacha de chocolate", 1000);
            
            Console.WriteLine($"Codigo {produto3.Codigo}, nome {produto3.Nome},  Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");
            
        }
    }
}
