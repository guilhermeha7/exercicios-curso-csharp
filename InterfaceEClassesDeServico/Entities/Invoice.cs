using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2")
                + "\nTax: "
                + Tax.ToString("F2")
                + "\nTotal payment: "
                + TotalPayment.ToString("F2");
        }
    }
}
