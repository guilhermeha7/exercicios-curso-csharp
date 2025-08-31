using System;
using Linq4.Entities;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "in.csv");
            List<Product> products = new List<Product>();

            using (StreamReader reader = new StreamReader(path)) //Já abre imediatamente o arquivo para leitura
            {
                while (!reader.EndOfStream)
                {
                    string[] lines = reader.ReadLine().Split(',');
                    string name = lines[0];
                    //O arquivo in.csv apresenta os preços no formato americano, então deve-se usar CultureInfo.InvariantCulture para ele ler corretamente o preço, para depois poder converter para o formato brasileiro
                    double price = double.Parse(lines[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            //Usar DefaultIfEmpty(0.0) antes de chamar Average() evita InvalidOperationException caso não haja elementos para se fazer a média. Assim, se a coleção recebido pelo Average estiver vazia, a média será 0.0
            var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Preço médio dos produtos: " + average.ToString("F2"));
            Console.WriteLine();

            var names = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
