using ListForEach;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("TV", 1000.0),
                new Product("Smartphone", 2000.0),
                new Product("Xbox Series S", 3000.0)
            };

            //products.Select pode-se ler como: Para cada elemento da lista faça essa ação e retorne a lista de valores para uma variável (pega uma coleção, transforma e manda para outra coleção)
            List<string> result = products.Select(p => p.Name = p.Name.ToUpper()).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
