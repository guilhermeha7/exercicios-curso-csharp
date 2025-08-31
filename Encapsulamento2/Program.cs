using Encapsulamento2;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero; 
            string titular;
            string sOuN;
            double valorDeposito;
            double valorSaque;

            Console.WriteLine("Cadastro Conta Bancária:");
            Console.Write("Número da conta: ");
            numero = Console.ReadLine();
            Console.Write("Titular da conta: ");
            titular = Console.ReadLine();

            ContaBancaria contaBancaria = new ContaBancaria(numero, titular);

            Console.WriteLine("Haverá depósito inicial? (s/n)");
            sOuN = Console.ReadLine();

            if (sOuN == "s")
            {
                Console.WriteLine();
                Console.Write("Digite um valor para o depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine());
                contaBancaria.Depositar(valorDeposito);
                Console.WriteLine("Dados da conta: ");
                contaBancaria.MostrarDados();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                contaBancaria.MostrarDados();
            }

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine());
            contaBancaria.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            contaBancaria.MostrarDados();

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            valorSaque = double.Parse(Console.ReadLine());
            contaBancaria.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            contaBancaria.MostrarDados();



        }
    }
}