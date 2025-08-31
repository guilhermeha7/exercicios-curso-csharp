using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matriz.Length: retorna o número de elementos no total
            //matriz.Rank: retorna o número de linhas da matriz no total
            //matriz.GetLength(int dimensão): insira a dimensão desejada (x ou y) para se descobrir a quantidade de elementos nessa dimensão 
            
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(valores[j]);
                }

            }

            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i]+" ");
            }

            int contagem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.WriteLine("Qtd de Números Negativos: " + contagem);
        }
    }
}