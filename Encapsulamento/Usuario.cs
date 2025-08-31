using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Usuario
    {
        //Todos são atributos privados para que eu não consiga alterar diretamente seus valores
        private string Cpf;
        private string Senha;
        private double Saldo;

        public Usuario(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;
            Saldo = 0.0;
        }

        public double GetSaldo(string cpf, string senha) //O usuário digitou um cpf e senha
        {
            if (cpf == Cpf && senha == Senha)  //Se os dados digitados forem iguais ao dados armazenados
            {
                return Saldo; //O saldo da conta será mostrado
            }
            throw new UnauthorizedAccessException("CPF ou senha inválidos.");

        }
    }
}
