using Enumeracoes.Entities.Enums;
using Enumeracoes.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Horario = DateTime.Now,
                Status = StatusPedido.PagamentoPendente
            };

            string txt = StatusPedido.PagamentoPendente.ToString();
            StatusPedido os = Enum.Parse<StatusPedido>("Entregue");

            Console.WriteLine(pedido);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}