using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            
            //Estrutura Condicional Ternária: variável = (condição) ? (operação na variável se a condição for verdadeira) : (operação na variável se a condição for falsa) 
            double desconto = (preco >= 100.0) ? preco * 0.1 : 0;
            double valorFinal = preco - desconto;

            Console.WriteLine("Valor final: " + valorFinal);
        }
    }
}