using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal class Reservation
    {
        public Passenger ReservedPassenger { get; set; }
        public Vehicle ReservedVehicle { get; set; }
        public int SeatNumber { get; set; }
    }
}
