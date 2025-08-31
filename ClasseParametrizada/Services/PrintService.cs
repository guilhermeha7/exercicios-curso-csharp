using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseParametrizada.Services
{
    internal class PrintService<T> //Uma classe parametrizada permite trabalhar com qualquer tipo de dado que você escolher depois
    {
        private T[] _values = new T[10]; //Cria o vetor values, com 10 posições
        private int _count = 0; //Inicialmente vai guardar o valor na posição 0

        public void AddValue(T value)
        {
            _values[_count] = value;
            _count++;
        }

        public T GetFirstValue()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++) 
            {
                Console.Write(_values[i] + ", "); 
            }
            Console.Write(_values[_count - 1]);
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
