using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodosAbstratos2.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double CalcularImposto()
        {
            if (NumeroDeFuncionarios >= 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
