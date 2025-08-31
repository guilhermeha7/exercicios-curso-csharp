using MembrosEstaticos2;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantiaDolares = double.Parse(Console.ReadLine());

            double valorASerPago = ConversorDeMoeda.DolarParaReal(quantiaDolares, cotacao);
        
            Console.WriteLine("Valor a ser pago em reais = " + valorASerPago.ToString("F2"));
        }
    }
}