using ClassesEMetodosAbstratos.Entities;
using ClassesEMetodosAbstratos.Entities.Enums;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa que guarda dados de figuras geométricas e calcula a área delas
            Console.Write("Digite o número de figuras: ");
            int n = int.Parse(Console.ReadLine());
            List<Figura> figuras = new List<Figura>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Figura {i}");
                Console.Write("Cor (Roxo, branco, preto): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                Console.Write("Retângulo ou Círculo (r ou c)? ");
                char caracter = char.Parse(Console.ReadLine());
                if (caracter == 'r')
                {
                    Console.Write("Largura (x): ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Altura (y): ");
                    double y = double.Parse(Console.ReadLine());
                    figuras.Add(new Retangulo(x, y, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    figuras.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("CÁLCULO DAS ÁREAS: ");
            foreach (Figura figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea().ToString("F2"));
            }

        }
    }
}