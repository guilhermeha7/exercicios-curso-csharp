using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico2.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installment(DateTime date, double value)
        {
            DueDate = date;
            Value = value;
        }
    }
}
