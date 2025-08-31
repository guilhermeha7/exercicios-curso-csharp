using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //IEnumerable é uma coleção bem genérica
            //numbers.Where(x => x % 2 == 0) pode-se ler como: Vou pegar na coleção "numbers" todo número que tem resto igual a 0 /todo número x tal que x tem resto igual a 0
            //O Select após a operação numbers.Where seleciona o resultado da operação e faz com cada elemento uma operação entre parênteses
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x = x * 10);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
