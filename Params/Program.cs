using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = Soma(2, 4, 5);
            Console.WriteLine(soma);

        }

        static int Soma(params int[] numeros)
        {
            /*params é um recurso da linguagem C# que permite passar um número variável 
            de argumentos para um método.*/
            int total = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                total += numeros[i];
            }
            return total;
        }
    }
}