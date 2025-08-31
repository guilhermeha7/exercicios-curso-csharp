using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            /*Semântica do bloco: Atribua posições x e y para os números inteiros digitados pelo usuário*/
            //Em cada linha da matriz
            for (int i = 0; i < m;  i++)
            {
                //Armazene os valores que o usuário digitar
                string[] valores = Console.ReadLine().Split(' ');

                //E então em cada coluna da matriz
                for (int j = 0; j < n; j++)
                {
                    //Armazene na matriz a posição do valor atualmente analizado
                    matriz[i, j] = int.Parse(valores[j]);
                }

            }

            Console.Write("Digite um número inteiro para descobrir suas posições e valores adjacentes: ");
            int nAnalisado = int.Parse(Console.ReadLine());
            int[,] posicoes = new int[m, n];

            //Semântica do bloco: Percorrendo a matriz descubra a posição do nAnalisado
            for (int i = 0; i < m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    //Se o valor guardado na posição atualmente analisada da matriz for igual a nAnalisado então guardar o x da matriz na variável x 
                    if (matriz[i, j] == nAnalisado)
                    {
                        Console.WriteLine("Posição (" + i + ", " + j + ")");

                        if (j > 0)
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);

                        if (j < n - 1)
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);

                        if (i > 0)
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);

                        if (i < m - 1)
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);

                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}