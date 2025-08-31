using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao3.Entities
{
    internal class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public double Calcular()
        {
            return Quantidade * Preco;
        }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public override string ToString()
        {
            return Produto.Nome + ", R$" + Preco + ", " + "Quantidade: " + Quantidade + ", " + "Subtotal: R$" + Calcular(); 
        }
    }
}
