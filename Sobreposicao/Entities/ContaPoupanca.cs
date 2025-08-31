using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupanca(int numero, string proprietario, double saldo, double taxaDeJuros)
        : base(numero, proprietario, saldo) // Chama o construtor da classe Conta
        {
            TaxaDeJuros = taxaDeJuros;
        }


        public void AtualizarSaldo()
        {
            Saldo = Saldo + (Saldo * TaxaDeJuros);
        }

        public override void Sacar(double quantia)
        {
            Saldo = Saldo - quantia;
        }
    }
}
