using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico3.Services
{
    internal class PayPalService : IPaymentService
    {
        public double CalcInterest(double amount, int month)
        {
            return amount * 0.01 * month;
        }

        public double CalcPaymentRate(double amount)
        {
            return amount * 0.02;
        }
    }
}
