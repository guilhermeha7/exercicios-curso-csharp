using System;
using ExtensionMethods.Extensions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 06, 16, 14, 00, 00);
            Console.WriteLine(dt.ElapsedTime()); //Tempo decorrido até o momento

            string post = "Good morning";
            Console.WriteLine(post.Cut(10));
        }
    }
}
