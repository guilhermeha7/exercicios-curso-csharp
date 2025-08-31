using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca3.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaDeAlfandega { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaDeAlfandega)
            : base(nome, preco)
        {
            TaxaDeAlfandega = taxaDeAlfandega;
        }

        public double CalcularPreco()
        {
            return Preco + TaxaDeAlfandega;
        }

        public override void MostrarEtiqueta()
        {
            Console.WriteLine(Nome + ", R$" + CalcularPreco().ToString("F2") + " (Taxa de Alfandega: R$" + TaxaDeAlfandega.ToString("F2") + ")");
        }
    }
}
