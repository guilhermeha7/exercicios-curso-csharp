using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    internal class Aluno
    {
        public string Nome;
        public float Nota1;
        public float Nota2;
        public float Nota3;

        public float GetNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool VerificarAprovacao()
        {
            if (GetNotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float GetNotaRestanteParaAprovacao()
        {
            if (VerificarAprovacao() == true)
            {
                return 0.0f;
            }
            else
            {
                return 60.0f - GetNotaFinal();
            }
        }

    }
}
