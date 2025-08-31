using Classes3;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usuário informa os dados do produto
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            //O produto é salvo no sistema e são mostrados na tela os dados do produto
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);


            //O usuário aumenta o estoque do produto criado
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtdAdicionada = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtdAdicionada);
            Console.WriteLine("Dados atualizados: " + p);


            //O usuário diminui o estoque do produto criado
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtdASerRemovida = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtdASerRemovida);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}