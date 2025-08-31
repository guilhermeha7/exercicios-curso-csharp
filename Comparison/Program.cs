using System;
using Comparison.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Mouse", Price = 50 },
                new Product { Name = "Monitor", Price = 1000 },
                new Product { Name = "Teclado", Price = 150 }
            };

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + ": " + product.Price);
            }
        }
    }
}
