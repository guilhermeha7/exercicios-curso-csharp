using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composicao3.Entities.Enums;

namespace Composicao3.Entities
{
    internal class Pedido
    {
        public DateTime Horario { get; set; }
        public StatusDoPedido Status { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public Cliente Cliente { get; set; }

        public Pedido(DateTime horario, StatusDoPedido status, Cliente cliente)
        {
            Horario = horario;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double CalcularValorTotal()
        {
            double total = 0;

            foreach (ItemPedido item in Itens)
            {
                total += item.Calcular();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("Resumo do pedido: ");
            sb.AppendLine("Horário: " + Horario);
            sb.AppendLine("Status: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido: ");
            foreach (ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("Valor Total: R$" + CalcularValorTotal());
            return sb.ToString();
        }
    }
}
