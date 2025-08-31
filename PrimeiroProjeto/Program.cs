using System;
using System.Reflection.Metadata;

namespace PrimeiroProjeto //namespace é um agrupamento de classes relacionadas. Em analogia, é como se fosse gavetas de classes
{
    internal class Program
    {
        static void Main(string[] args) //O procedimento static void Main é o ponto de entrada da aplicação. Onde a aplicação começa a ser executada
        {
            double saldo = 1000000.389432;
            string nome = "Thomas";

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine($"{nome} tem conta no banco e possui o saldo igual a {saldo:F2}");
            Console.WriteLine(nome + " tem conta no banco e possui o saldo igual a " + saldo.ToString("F2"));
        }
    }
}
