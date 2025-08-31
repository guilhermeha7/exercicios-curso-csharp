using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable.Entities
{
    internal class Employee : System.IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] partes = csvEmployee.Split(',');
            Name = partes[0];
            Salary = double.Parse(partes[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee)) //Programação defensiva. Se o objeto colocado como parâmetro não for do tipo Employee
            {
                throw new ArgumentException("Error: argument is not an Employee");
            }
            Employee other = obj as Employee; //Tenta converter um objeto genérico para Employee e guarda na variável other
            
            return Name.CompareTo(other.Name);
        }
    }
}
