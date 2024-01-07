using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal class Trip
    {
        public string VehicleType { get; set; }
        public Route TripRoute { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }

        public Trip(string vehicleType, Route tripRoute, DateTime departureTime, decimal price)
        {
            VehicleType = vehicleType;
            TripRoute = tripRoute;
            DepartureTime = departureTime;
            Price = price;
        }
    }
}
