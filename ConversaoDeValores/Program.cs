using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double divisao = (double)10 / 8; //É preciso adicionar o (double) para o compilador gerar um resultado com vírgula ou fazer 10.0 * 8.0
            double saldo = 1000.52;
            long saldoEmInteiro;

            saldoEmInteiro = (long)saldo;

            Console.WriteLine(saldoEmInteiro); //Ocorreu perda de valor!
            Console.WriteLine(divisao);
        }
    }
}