using System;
using TratamentoDeExcecoesPersonalizadas.Entities;
using TratamentoDeExcecoesPersonalizadas.Entities.Exceptions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Programa que permite a criação e atualização de uma reserva de hotel*/
            try // Tente executar:
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("");

                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine("");

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("");

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e) //Se der algum erro relacionado ao negócio então, execute:
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            

        }
    }
}