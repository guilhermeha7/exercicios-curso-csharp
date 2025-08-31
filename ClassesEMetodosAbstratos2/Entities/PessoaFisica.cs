using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodosAbstratos2.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double DespesaComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double despesaComSaude) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            DespesaComSaude = despesaComSaude;
        }

        public override double CalcularImposto()
        {
            double despesaComSaudeAbatida = DespesaComSaude * 0.50;

            if (RendaAnual <= 20000)
            {
                return (RendaAnual * 0.15) - despesaComSaudeAbatida;
            }
            else
            {
                return (RendaAnual * 0.25) - despesaComSaudeAbatida;
            }
        }
    }
}
