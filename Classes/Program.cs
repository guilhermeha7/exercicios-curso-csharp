using Classes;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). 
            Em seguida, mostrar o valor das àreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área. 
            A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b, c é a fórmula de Heron*/
            
            //Criação das instâncias/objetos a partir da classe Triângulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Escreva as medidas dos lados do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva as medidas dos lados do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.CalcularArea();
            Console.WriteLine("A área do triângulo X é: " + areaX.ToString("F4"));

            double areaY = y.CalcularArea();
            Console.WriteLine("A área do triângulo Y é: " + areaY.ToString("F4"));

            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}