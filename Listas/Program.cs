using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "João", "José" };

            list2.Add("Bob");

            list2.Insert(2, "Alex"); //O método insert adiciona um item na posição especificada. O item que estava na posição, não é excluido, ele tem a sua posição aumentada em 1.

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Número de elementos: " + list2.Count); 
        }
    }
}