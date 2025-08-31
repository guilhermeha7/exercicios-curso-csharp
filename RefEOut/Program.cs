using System;
using System.Net.NetworkInformation;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            Triplo(ref a);
            Console.WriteLine(a);

            double b = 10.0;
            double resultado;
            Triplo2(b, out resultado);
            Console.WriteLine(resultado);
        }

        static void Triplo(ref double numero)
        {
            numero = numero * 3;
        }

        static void Triplo2(double numero,  out double resultado)
        {
            resultado = numero * 3;
        }
    }
}