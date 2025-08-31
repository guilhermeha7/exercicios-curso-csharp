using ClassesEMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodosAbstratos.Entities
{
    internal class Retangulo : Figura
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Retangulo(double x, double y, Cor cor) : base(cor)
        {
            X = x;
            Y = y;
            Cor = cor;
        }

        public override double CalcularArea()
        {
            return X * Y;
        }
    }
}
