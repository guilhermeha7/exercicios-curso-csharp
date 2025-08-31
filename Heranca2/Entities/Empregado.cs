using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2.Entities
{
    internal class Empregado
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }

        public Empregado(string nome, int horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        public virtual double CalcularPagamento()
        {
            return HorasTrabalhadas * ValorPorHora;
        }
    }
}
