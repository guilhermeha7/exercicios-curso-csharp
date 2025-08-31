using System;
using Vetor3;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos você vai alugar?");
            int n = int.Parse(Console.ReadLine());
            Estudante[] quartos = new Estudante[10]; //Crie 10 quartos e armazene estudantes neles
            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #"+(i+1));

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                while(true) //O código a seguir será repetido até que o comando break apareça
                {
                    Console.Write("Quarto para Alugar: ");
                    int idQuartoParaAlugar = int.Parse(Console.ReadLine());

                    if (quartos[idQuartoParaAlugar] == null)
                    {
                        quartos[idQuartoParaAlugar] = new Estudante(nome, email, idQuartoParaAlugar);
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Esse quarto já está ocupado no momento, digite outro");
                    }
                }
            }

            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0;i < quartos.Length;i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i].IdQuarto + ": " + quartos[i].Nome+", "+ quartos[i].Email);
                }
            }


        }
    }
}

