using Sobreposicao.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa onde o usuário cria uma conta comum e uma conta poupança, 
            deposita R$100,00 em cada e depois saca R$50,00 de cada.
            A conta poupança tem taxa 0 no saque e a conta comum tem R$5,00 de taxa*/
            Conta cc = new Conta(1000, "Guilherme", 0);
            ContaPoupanca cp = new ContaPoupanca(1001, "Guilherme", 0, 0.15);
            cc.Depositar(100);
            cp.Depositar(100);
            cc.Sacar(50);
            cp.Sacar(50);
            Console.WriteLine("Saldo da Conta Corrente: R$" + cc.Saldo);
            Console.WriteLine("Saldo da Conta Poupança: R$" + cp.Saldo);
        }
    }
}