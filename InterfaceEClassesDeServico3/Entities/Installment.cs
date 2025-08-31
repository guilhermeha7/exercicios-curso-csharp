using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico3.Entities
{
    internal class Installment
    {
        public DateTime DueTime { get; set; }
        public double Value { get; set; }

        public Installment(DateTime dueTime, double value)
        {
            DueTime = dueTime;
            Value = value;
        }

        public override string ToString()
        {
            return DueTime + ", " + Value;
        }
    }
}
