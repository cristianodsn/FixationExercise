using System;
using Exceptions01.Entities.exceptions;

namespace Exceptions01.Entities
{
    class Reservation
    {
        public int Number { get; protected set; }
        public DateTime Checkin { get; protected set; }
        public DateTime Checkout { get; protected set; }

        public Reservation(int number, DateTime checkin, DateTime checkout)
        {
            if(checkin >= checkout)
            {
                throw new DomainExceptions("Check-out date must be after check-in date");
            }

            Number = number;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Dutarion()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin >= checkout)
            {
                throw new DomainExceptions("Check-out date must be after check-in date");
            }
            if (Checkin > checkin || Checkin == checkin && Checkout == checkout)
            {
                throw new DomainExceptions("Reservaiton date for update must be future dates");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return
                $"Reservation: " +
                $"Room: {Number}, " +
                $"check-in: {Checkin.ToString("dd/MM/yyyy")}, " +
                $"check-out: {Checkout.ToShortDateString()}, " +
                $"{Dutarion()} nights";
        }
    }
}
