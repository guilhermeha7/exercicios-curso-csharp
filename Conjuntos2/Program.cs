using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6 };
            SortedSet<int> b = new SortedSet<int>() { 1, 3, 5, 7 };

            //União de conjuntos
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //Vai ser inserido dentro do conjunto c, os elementos do b
            Console.Write("Union: ");
            PrintCollection<int>(c);

            //Intersecção de conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); //O conjunto d vai receber o que estava em comum entre o conjunto d e b
            Console.Write("Intersection: ");
            PrintCollection<int>(d);

            //Diferença de conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); //Remove do conjunto 'e' os elementos que também existem em 'b'
            Console.Write("Difference: ");
            PrintCollection<int>(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
        }
    }
}
