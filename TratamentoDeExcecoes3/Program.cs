using System;
using TratamentoDeExcecoes3.Entities;
using TratamentoDeExcecoes3.Entities.Exceptions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("CADASTRAR NOVA CONTA BANCÁRIA:");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite de Saque: ");
                double limiteDeSaque = double.Parse(Console.ReadLine());
                Conta conta = new Conta(numero, nome, saldo, limiteDeSaque);
                Console.WriteLine();

                Console.Write("Digite a quantia para sacar: ");
                double valorASacar = double.Parse(Console.ReadLine());
                conta.Sacar(valorASacar);
                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
