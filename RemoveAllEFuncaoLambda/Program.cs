using System;
using RemoveAllEFuncaoLambda;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("TV",1000.0),
                new Product("Smartphone",2000.0),
                new Product("Xbox Series S",3000.0)
            };

            products.RemoveAll(p => p.Price <= 2500.0); //RemoveAll é um método exclusivo de List<T>

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + ": " + p.Price);
            }
        }
    }
}
