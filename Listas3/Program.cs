using Listas3;
using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Empregado #" + (i + 1));
                Console.WriteLine("");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Funcionario funcionario = new Funcionario(id, nome, salario);
                funcionarios.Add(funcionario);
                //Outra possibilidade: funcionarios.Add(new Funcionario(id, nome, salario));
            }

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Qual é o id do funcionário que receberá o aumento? ");
                int idFuncionarioSortudo = int.Parse(Console.ReadLine());
                Funcionario funcionarioDoAumento = funcionarios.Find(e => e.Id == idFuncionarioSortudo);

                Console.WriteLine("");
            
                if (funcionarioDoAumento != null)
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double percentual = double.Parse(Console.ReadLine());
                    funcionarioDoAumento.AumentarSalario(percentual);
                    Console.WriteLine("");
                    Console.WriteLine("Lista de empregados atualizada: ");
                    foreach (Funcionario funcionario in funcionarios)
                    {
                        Console.WriteLine(funcionario);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Este ID não existe!");
                }
            }

        }
    }
}
