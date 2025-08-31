using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca3.Entities
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao)
        : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override void MostrarEtiqueta()
        {
            Console.WriteLine(Nome + " (Usado), R$" + Preco.ToString("F2") + " (Data de fabricação: " + DataDeFabricacao.ToShortDateString() + ")");
        }
    }
}
