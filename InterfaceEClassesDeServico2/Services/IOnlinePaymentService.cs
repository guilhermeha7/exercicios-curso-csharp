using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEClassesDeServico2.Services
{
    interface IOnlinePaymentService
    {
        double CalcPaymentFee(double amount);
        double CalcInterest(double amount, int month);
    }
}
