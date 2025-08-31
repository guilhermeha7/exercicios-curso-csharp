using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    internal class ContaBancaria
    {
        //A nomenclatura _underscore se aplica a atributos privados
        private string _numero;
        private string _titular;
        private double _saldo;

        public ContaBancaria(string numero, string titular) //Na criação da conta bancária, é exigido fornecer o nome e o número da conta
        {
            _numero = numero;
            _titular = titular;
        }

        public string Numero //O método Número ao ser chamado permite obter o número da conta somente
        {
            get 
            {
                return _numero; 
            }
        }

        public string Titular
        {
            get
            {
                return _titular;
            }

            set
            {
                if (value != null && value.Length > 0)
                {
                    _titular = value;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }

        public double Depositar(double valor)
        {
            return _saldo = _saldo + valor;
        }

        public double Sacar(double valor)
        {
            return _saldo = _saldo - valor - 5.0;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Conta: " + _numero + ", Titular: " + _titular + ", Saldo: R$" + _saldo);
        }


    }
}
