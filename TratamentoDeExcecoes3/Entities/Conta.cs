using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeExcecoes3.Entities.Exceptions;

namespace TratamentoDeExcecoes3.Entities
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Proprietario { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; set; }

        public Conta(int numero, string proprietario, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Proprietario = proprietario;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo == 0)
            {
                throw new DomainException("Não é possível sacar com o saldo da conta vazio.");
            }
            else if (Saldo < valor)
            {
                throw new DomainException("Saldo insuficiente.");
            }
            else if (valor > LimiteDeSaque)
            {
                throw new DomainException("Não é possível sacar uma quantia acima do limite de saque");
            }
                Saldo -= valor;
        }
    }
}
