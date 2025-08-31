using System;
using ClassesEMetodosAbstratos2.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            List<Contribuinte> contribuintes = new List<Contribuinte>();
            Console.WriteLine("");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuinte {i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                Console.Write("PF ou PJ? ");
                string tipoDePessoa = Console.ReadLine();
                if (tipoDePessoa == "PF" || tipoDePessoa == "pf")
                {
                    Console.Write("Gasto com Saúde: ");
                    double gastoComSaude = double.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaFisica(nome, rendaAnual, gastoComSaude));
                }
                else
                {
                    Console.Write("Número de Funcionários: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, rendaAnual, numeroDeFuncionarios));
                }
                Console.WriteLine("");
            }

            double total = 0;
            Console.WriteLine("IMPOSTO PAGO: ");
            foreach (Contribuinte contribuinte in contribuintes)
            {
                total += contribuinte.CalcularImposto();
                Console.WriteLine(contribuinte.Nome + ": R$" + contribuinte.CalcularImposto().ToString("F2"));
            }
            Console.WriteLine("");
            Console.WriteLine("Total: R$" + total);



        }
    }
}