using System;
using ListForEach;

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
            //products.ForEach pode-se ler como: Para cada elemento da lista faça essa ação. Como não tem retorno, diferente do método Select, não se usa para armazenar em uma variável
            products.ForEach(p => p.Price += p.Price * 0.10);
            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + ": " + p.Price);
            }
        }
    }
}