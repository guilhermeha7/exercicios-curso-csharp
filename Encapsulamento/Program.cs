using Encapsulamento;
using System;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa onde o usuário ao digitar um CPF e senha, consegue visualizar seu saldo bancário
            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            Usuario usuario = new Usuario(cpf, senha);

            Console.WriteLine("Seu saldo é: " + usuario.GetSaldo(cpf, senha));

        }
    }
}
