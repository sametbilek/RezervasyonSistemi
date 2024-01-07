using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal interface IReservable
    {

        void ReserveSeat(Reservation reservation);
        void CancelReservation(Reservation reservation);
        bool IsSeatAvailable(Vehicle vehicle, int seatNumber);
    }
}
