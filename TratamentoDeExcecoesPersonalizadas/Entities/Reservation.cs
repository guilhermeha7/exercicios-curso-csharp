using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeExcecoesPersonalizadas.Entities.Exceptions;

namespace TratamentoDeExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; } //Data de entrada no hotel
        public DateTime CheckOut { get; set; } //Data de saída no hotel

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de saída da reserva deve ser uma data futura em relação à data de entrada");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn.Date;
            CheckOut = checkOut.Date;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); //a variável duration recebe a diferença de dias das datas de saída e entrada
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de saída da reserva deve ser uma data futura em relação à data de entrada"); //Lança a exceção DomainException, o throw interrompe a execução do método como o return
            }
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("As datas de entrada e saída da reserva devem ser datas futuras"); 
            }
            CheckIn = checkIn.Date;
            CheckOut = checkOut.Date;

        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", Check-in: "
                + CheckIn
                + ", Check-out: "
                + CheckOut 
                + ", "
                + Duration()
                + " nights";
        }
    }
}
