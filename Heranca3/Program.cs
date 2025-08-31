using Heranca3.Entities;
using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para gravar os dados de produtos e mostrá-los na tela depois
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Produto> produtos = new List<Produto>();
            Console.WriteLine("");
            

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Produto #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("É comum, importado ou usado (c/i/u)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'u')
                {
                    Console.Write("Insira a data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, data));
                }
                else if (ch == 'i')
                {
                    Console.Write("Insira a taxa de alfandêga: ");
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else
                {
                    produtos.Add(new Produto(nome, preco));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Dados dos produtos: ");
            foreach (Produto produto in produtos)
            {
                produto.MostrarEtiqueta();
            }
        }
    }
}