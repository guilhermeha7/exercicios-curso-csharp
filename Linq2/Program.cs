using Linq2.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.0, c2),
                new Product(2, "Hammer", 90.0, c1),
                new Product(3, "TV", 1700.0, c3),
                new Product(4, "Notebook", 1300.0, c2),
                new Product(5, "Saw", 80.0, c1),
                new Product(6, "Tablet", 700.0, c2),
                new Product(7, "Camera", 700.0, c3)
            };

            //Imprimir produtos que tenham Categoria.Tier == 1 e Preço < 900.0
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Produtos com Categoria.Tier == 1 e Preço < 900.0", r1);

            //Imprimir os nomes dos produtos que tenham Tools (apenas os nomes)
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //O Select sempre retorna uma coleção 
            Print("Produtos com Categoria.Name == 'Tools'", r2);

            //Imprimir nome, preço e categoria dos produtos que começam com a letra C
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Produtos que começam com a letra C", r3);

            //Imprimir produtos com Category.Tier == 1 ordenando por preço e depois por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Produtos com Categoria.Tier == 1, ordenado de forma crescente por preço e depois por nome", r4);

            var r5 = r4.Skip(2).Take(2); //Pule os dois primeiros elementos da coleção e depois pegue 4 elementos
            Print("Produtos com Categoria.Tier == 1, ordenado de forma crescente por preço e depois por nome. Pulando os dois primeiros elementos da coleção e exibindo 2 depois", r5);

            try
            {
                var r6 = products.Where(p => p.Price > 10000).First(); //First() mostra uma exceção se a coleção não tiver nenhum elemento, exigindo tratamento
                Console.WriteLine("First(): " + r6);
                Console.WriteLine("");
            }
            catch (InvalidOperationException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("");
            }


            var r7 = products.Where(p => p.Price > 10000).FirstOrDefault(); //FirstOrDefault() não mostra uma exceção se a coleção não tiver nenhum elemento
            Console.WriteLine("FirstOrDefault(): " + r7); //Nesse caso é possível usar Console.WriteLine, pois r7 vai retornar somente um elemento com FisrtOrDefault, se retornasse uma coleção teria que usar foreach
            Console.WriteLine("");

            var r8 = products.Max(p => p.Price);
            Console.WriteLine("Preço máximo: " + r8);
            Console.WriteLine("");

            var r9 = products.Min(p => p.Price);
            Console.WriteLine("Preço mínimo: " + r9);
            Console.WriteLine("");

            var r10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Soma dos produtos da categoria 1: " + r10);
            Console.WriteLine("");

            var r11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Média dos preços da categoria 1: " + r11);
            Console.WriteLine("");

            //O Select sempre retorna uma coleção, com essa 
            var r12 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); //DefaultIfEmpty faz com que se a coleção retornada anteriormente estiver vazia, ao invés do programa lançar a exceção "Coleção não contém elementos", ele irá mostrar um valor padrão.
            Console.WriteLine("Média dos preços da categoria 5: " + r12);
            Console.WriteLine("");

            var r13 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma dos produtos da categoria 1 usando Agreggate: " + r13);
            Console.WriteLine("");

            var r14 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r14)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("");
            }
        }
    }
}
