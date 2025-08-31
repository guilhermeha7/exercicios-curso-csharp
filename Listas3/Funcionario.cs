using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas3
{
    internal class Funcionario
    {
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void AumentarSalario(double percentualAumento)
        {
            //Salario = Salario + Salario * (percentualAumento / 100.0);
            Salario += Salario * (percentualAumento / 100.0);
        }

        public override string ToString()
        {
             
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}
