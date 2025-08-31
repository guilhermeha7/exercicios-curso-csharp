using System;
using System.Linq;
using System.Globalization;
using Linq5.Entities;
using System.Reflection.Metadata.Ecma335;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "employees.csv");
            List<Employee> employees = new List<Employee>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] blocks = reader.ReadLine().Split(",");
                    string name = blocks[0];
                    string email = blocks[1];
                    double salary = double.Parse(blocks[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Qual é o salário mínimo que o funcionário precisa ter para ter seu email listado? ");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine();

            var emails = employees.Where(e => e.Salary > min).Select(e => e.Email).Order();
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();

            var sumOfSalaries = employees.Where(e => e.Name[0]=='M').Select(e => e.Salary).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma dos salários dos funcionários que começam com a letra M: R$" + sumOfSalaries);
        }
    }
}
