using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InterfaceEClassesDeServico2.Entities;

namespace InterfaceEClassesDeServico2.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Entities.Contract contract, int months)
        {
            double baseValue = contract.Value / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime installmentDate = contract.Date.AddMonths(i);

                double valueWithInterest = baseValue + _onlinePaymentService.CalcInterest(baseValue, i);
                double totalValue = valueWithInterest + _onlinePaymentService.CalcPaymentFee(valueWithInterest);

                contract.Installments.Add(new Installment(installmentDate, totalValue));


            }
        }
    }
}
