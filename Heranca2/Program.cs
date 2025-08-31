using System;
using System.Collections.Generic;
using Heranca2.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            List<Empregado> empregados = new List<Empregado>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Nº de Horas Trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("É Tercerizado? (s/n): ");
                char tercerizado = char.Parse(Console.ReadLine());

                if (tercerizado == 's')
                {
                    Console.Write("Pagamento Adicional: ");
                    double pagAdicional = double.Parse(Console.ReadLine());
                    empregados.Add(new EmpregadoTercerizado(nome, horas, valorPorHora, pagAdicional));
                }
                else
                {
                    empregados.Add(new Empregado(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Pagamentos:");
            foreach (Empregado empregado in empregados)
            {

                Console.WriteLine(empregado.Nome + ", R$" + empregado.CalcularPagamento().ToString("F2"));
            }

        }
    }
}
