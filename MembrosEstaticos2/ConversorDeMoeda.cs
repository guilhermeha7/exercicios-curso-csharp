using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos2
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06; //=6%
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + (total * Iof);   
        }
    }
}
