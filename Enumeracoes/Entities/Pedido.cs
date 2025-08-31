using Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.Entities

{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Horario + ", " + Status;
        }
    }
}
