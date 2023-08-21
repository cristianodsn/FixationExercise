using System;
using Exceptions01.Entities;
using Exceptions01.Entities.exceptions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine(reservation);
                Console.WriteLine();

                Console.WriteLine("Enter date to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine(reservation);
            }
            catch( DomainExceptions e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);

            }
            catch (SystemException e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }            
        }
    }
}
