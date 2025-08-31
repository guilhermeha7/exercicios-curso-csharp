using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento3
{
    internal class ContaBancaria
    {
        public string Numero { get; private set; } //Coloca-se private set para que o número da conta não possa ser alterado após ser criado
        public string Titular { get; set; }
        public double Saldo { get; private set; } //Coloca-se private set, para não ser possível alterar diretamente o valor do saldo, a não ser por depósito ou saque

        public ContaBancaria(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(string numero, string titular, double depositoInicial) : this(numero, titular) //Esse this é um maceta que pega o código do outro construtor
        {
            Depositar(depositoInicial);
        }
        
        public void Depositar(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Sacar(double quantia)
        {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2");

        }
    }
}
