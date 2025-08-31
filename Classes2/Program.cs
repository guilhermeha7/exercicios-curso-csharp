using Classes2;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler nome e salário de dois funcionários. 
            Depois, mostrar o salário médio dos funcionários.*/
            Funcionario Funcionario1, Funcionario2;
            Funcionario1 = new Funcionario();
            Funcionario2 = new Funcionario();
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario1.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            Funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario2.salario = float.Parse(Console.ReadLine());

            float salarioMedio = (Funcionario1.salario + Funcionario2.salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio);

        }
    }
}