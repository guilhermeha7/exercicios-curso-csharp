using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico2.Entities
{
    internal class Contract
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(string number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }
    }
}
