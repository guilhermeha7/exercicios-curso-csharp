using System;

namespace MyApp
{
    internal class Program
    {

        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = CalcularCircunferencia(raio);
            double volume = CalcularVolume(raio);

            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2"));
        }

        //Não é possível chamar uma função estática dentro de outra não-estática
        static double CalcularCircunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double CalcularVolume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}