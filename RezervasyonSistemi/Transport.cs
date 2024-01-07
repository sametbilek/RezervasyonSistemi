using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal class Transport:IReservable
    {
        public List<Company> Companies { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Trip> Trips { get; set; }

        public Transport()
        {
            Companies = new List<Company>();
            Vehicles = new List<Vehicle>();
            Trips = new List<Trip>();
        }


        public void ReserveSeat(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public void CancelReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool IsSeatAvailable(Vehicle vehicle, int seatNumber)
        {
            throw new NotImplementedException();
        }
    }
}
