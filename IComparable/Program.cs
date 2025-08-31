using IComparable.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\funcionarios.csv";
            //Adiciona os nomes do arquivo nome.txt na lista list
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //Ordena a lista( (mas só funciona se os objetos da lista implementarem IComparable<T>
                    
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
