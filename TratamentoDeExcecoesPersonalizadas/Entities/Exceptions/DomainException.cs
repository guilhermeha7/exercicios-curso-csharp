using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoesPersonalizadas.Entities.Exceptions
{
    internal class DomainException : ApplicationException //DomainException é um bom nome para se dar para exceções relacionadas ao negócio do sistema
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
