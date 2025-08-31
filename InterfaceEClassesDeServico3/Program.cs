using InterfaceEClassesDeServico3.Entities;
using InterfaceEClassesDeServico3.Services;
using System;

namespace MyApp //Objetivo: Criar um programa que descubra o valor das parcelas mensais de um empréstimo
{
    internal class Program 
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter loan data:");
            Console.Write("Number: ");
            string number = Console.ReadLine();
            Console.Write("Date (dd/MM/yyyy):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Loan value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int ni = int.Parse(Console.ReadLine());

            Loan loan = new Loan(number, date, value);
            LoanService loanService = new LoanService(new PayPalService());
            loanService.ProcessLoan(loan, ni);
            Console.WriteLine("Installments:");
            foreach (Installment installment in loan.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
