using ClasseParametrizada.Services;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            PrintService<int> printService = new PrintService<int>();

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.GetFirstValue());
        }
    }
}
