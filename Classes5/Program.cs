using Classes5;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em 
            seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o 
            salário do funcionário com base em uma porcentagem dada (somente o salário bruto é 
            afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe 
            projetada abaixo.*/

            Funcionario objFuncionario = new Funcionario();

            //Usuário informa os dados do funcionário
            Console.Write("Nome: ");
            objFuncionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            objFuncionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            objFuncionario.Imposto = double.Parse(Console.ReadLine());


            //Mostra o nome do funcionário e descobre o seu salário líquido
            Console.WriteLine("Funcionário: " + objFuncionario.MostrarDados());


            //O usuário digita uma porcentagem para aumentar o salário bruto
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            
            objFuncionario.AumentarSalario(porcentagem);


            //Mostra o novo salário líquido na tela
            Console.WriteLine("Dados atualizados: " + objFuncionario.MostrarDados());
            

        }
    }
}