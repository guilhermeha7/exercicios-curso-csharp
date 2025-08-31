using System;
using EqualsEGetHashCode.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comparar o email de dois clientes e verificar se são iguais ou não
            Client a = new Client { Name = "Maria", Email = "mario@gmail.com" };
            Client b = new Client { Name = "Mario", Email = "mario@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
