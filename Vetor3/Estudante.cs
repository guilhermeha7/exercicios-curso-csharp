using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor3
{
    internal class Estudante
    {
        public Estudante(string nome, string email, int idQuarto)
        {
            Nome = nome;
            Email = email;
            IdQuarto = idQuarto;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public int IdQuarto { get; set; }



    }
}
