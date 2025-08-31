using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico2.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double CalcPaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double CalcInterest(double amount, int month)
        {
            return amount * 0.01 * month;
        }
    }
}
