using Classes4;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano.
            (O primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).
            Ao final, mostrar qual a nota final do aluno no ano.
            Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
            Você deve criar uma classe Aluno para resolver este problema*/

            Aluno objAluno = new Aluno();

            //Usuário informa notas do aluno
            Console.Write("Nome do aluno: ");
            objAluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            objAluno.Nota1 = float.Parse(Console.ReadLine());
            objAluno.Nota2 = float.Parse(Console.ReadLine());
            objAluno.Nota3 = float.Parse(Console.ReadLine());


            //Programa calcula a nota final do aluno e exibe na tela
            float notaFinal = objAluno.GetNotaFinal();

            Console.WriteLine("Nota Final: " + notaFinal);
            
            if (objAluno.VerificarAprovacao() == true)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + objAluno.GetNotaRestanteParaAprovacao() + " PONTOS");
            }

        }
    }
}