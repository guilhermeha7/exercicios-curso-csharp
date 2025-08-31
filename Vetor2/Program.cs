using System;
using System.Net.Http.Headers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + vect[i];
            }

            double media = soma / n;
            Console.WriteLine("Média: "+media.ToString("F2"));
        }
    }
}