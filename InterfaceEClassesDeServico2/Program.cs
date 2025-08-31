using System;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using InterfaceEClassesDeServico2.Entities;
using InterfaceEClassesDeServico2.Services;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            string number = Console.ReadLine();
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            InterfaceEClassesDeServico2.Entities.Contract contract = new InterfaceEClassesDeServico2.Entities.Contract(number, date, value);
            Console.WriteLine("");

            Console.Write("Enter number of installments: ");
            int ni = int.Parse(Console.ReadLine());
            ContractService servico = new ContractService(new PaypalService());
            servico.ProcessContract(contract, ni);
            Console.WriteLine("");

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment.DueDate.ToString("dd/MM/yyyy") + " - R$" + installment.Value.ToString("F2"));
            }

        }
    }
}
