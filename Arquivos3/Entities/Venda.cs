using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos3.Entities
{
    internal class Venda
    {
        public string Produto { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }

        public Venda(string produto, DateTime data, double preco)
        {
            Produto = produto;
            Data = data;
            Preco = preco;
        }

        public override string ToString()
        {
            return Data.ToShortDateString() + ", " + Produto + ", " + "R$" + Preco.ToString("F2");
        }

        public bool IsSameDate(DateTime date)
        {
            if (date == Data)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
