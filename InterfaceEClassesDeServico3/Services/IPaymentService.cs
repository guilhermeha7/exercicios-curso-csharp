using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico3.Services
{
    internal interface IPaymentService
    {
        double CalcInterest(double amount, int month);
        double CalcPaymentRate(double amount);
    }
}
