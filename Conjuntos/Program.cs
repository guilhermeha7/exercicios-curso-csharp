using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Xbox Series S");
            set.Add("Xbox Series X");
            set.Add("PS5");

            Console.WriteLine(set.Contains("Computer")); 

            foreach (string element in set)
            {
                Console.WriteLine(element);
            }

        }
    }
}
