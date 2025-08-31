using Composicao3.Entities;
using Composicao3.Entities.Enums;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nasicmento (DD/MM/YYYY): ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, dataNasc);
            Console.WriteLine("");

            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Status: ");
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());
            Console.Write("Quantos itens para esse pedido? ");
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do item #" + i);
                Console.Write("Nome do produto: ");
                string nomeProd = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProd = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quant = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProd, precoProd);
                ItemPedido item = new ItemPedido(quant, precoProd, produto);
                pedido.AddItem(item);
            }

            Console.WriteLine(pedido);


        }
    }
}