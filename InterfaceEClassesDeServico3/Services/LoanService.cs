using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceEClassesDeServico3.Entities;

namespace InterfaceEClassesDeServico3.Services
{
    internal class LoanService
    {
        private IPaymentService _paymentService;

        public LoanService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessLoan(Loan loan, int months) //Descobre o valor das parcelas mensais de um empréstimo
        {
            double baseValue = loan.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dueTime = loan.Date.AddMonths(i);

                double updatedValue = baseValue + _paymentService.CalcInterest(baseValue, i);
                updatedValue += _paymentService.CalcPaymentRate(updatedValue);

                loan.Installments.Add(new Installment(dueTime, updatedValue));
            }

        }
    }
}
