using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11); //TimeSpan é um objeto que pode ser criado que simboliza uma duração, um período de tempo
            TimeSpan t2 = new TimeSpan(1, 30, 10);

            TimeSpan soma = t.Add(t2);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);

            Console.WriteLine("Soma: " + soma);
        }
    }
}