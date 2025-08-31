using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2.Entities
{
    internal class EmpregadoTercerizado : Empregado
    {
        public double PagamentoAdicional { get; set; }

        public EmpregadoTercerizado(string nome, int horasTrabalhadas, double valorPorHora, double pagamentoAdicional)
            : base(nome, horasTrabalhadas, valorPorHora)
        {
            PagamentoAdicional = pagamentoAdicional;
        }

        public override double CalcularPagamento()
        {
            return (HorasTrabalhadas * ValorPorHora) + (PagamentoAdicional * 1.1);
        }
    }
}
