using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEMetodosAbstratos.Entities.Enums;

namespace ClassesEMetodosAbstratos.Entities
{
    abstract internal class Figura //Não podemos criar um objeto a partir da classe Figura
    {
        public Cor Cor { get; set; }

        protected Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double CalcularArea(); //Obriga a usar implementações próprias em todas as classes filhas
    }
}
