using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> lista = new List<string> { "Ana", "João", "Maria", "Bob"};

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            //O método Find retorna o primeiro elemento que atenda à condição especificada
            string s1 = lista.Find(item => item[2] == 'b'); //Procure o primeiro item da lista cujo terceiro caractere é a letra 'b', e guarde esse valor na variável s1
            Console.WriteLine("Primeiro elemento que tem como terceiro caracter a letra 'b': " + s1);
            Console.WriteLine("");

            string s2 = lista.FindLast(item => item[1] == 'o'); //Procure o último item da lista cujo segundo caractere é a letra 'o', e guarde esse valor na variável s2
            Console.WriteLine("Último elemento que tem como segundo caracter a letra 'o': " + s2);
            Console.WriteLine("");

            int pos1 = lista.FindIndex(item =>  item[0] == 'A'); //Procure o primeiro item que tem como primeiro caracter a letra 'A', e retorne a posição dele na variável pos1
            Console.WriteLine("Primeiro elemento que tem como primeiro caracter a letra 'A': " + pos1);
            Console.WriteLine("");

            int pos2 = lista.FindLastIndex(item => item[0] == 'A'); //Procure o primeiro item que tem como primeiro caracter a letra 'A', e retorne a posição dele na variável pos2
            Console.WriteLine("Último elemento que tem como primeiro caracter a letra 'A': " + pos1);
            Console.WriteLine("");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");

            List<string> lista2 = lista.FindAll(item => item.Length == 5); //Procure todos os itens da lista que tem 5 caracteres e guarde eles na lista2

            foreach (string item in lista2)
            {
                Console.WriteLine("Todos os elementos que tem 5 caracteres: ");
                Console.WriteLine(item);
            }
        }
    }
}