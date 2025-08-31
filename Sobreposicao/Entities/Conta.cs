using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
    internal class Conta
    {
        public int Numero { get; protected set; }
        public string Proprietario { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta(int numero, string proprietario, double saldo)
        {
            Numero = numero;
            Proprietario = proprietario;
            Saldo = saldo;
        }

        public void Depositar(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public virtual void Sacar(double quantia)
        {
            Saldo = Saldo - quantia - 5.0;
        }
    }
}
