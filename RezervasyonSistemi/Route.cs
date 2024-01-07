using System;
using System.Collections.Generic;

namespace RezervasyonSistemi
{
    public class Route
    {
        public int RouteNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public List<string> ViaCities { get; set; }

        public int[,] DistanceMatrix { get; set; }
        public TravelMode Mode { get; set; }
        public DateTime DepartureDate { get; set; }
      

        public string FormattedDepartureDate
        {
            get { return DepartureDate.ToString("dd.MM.yyyy"); }
        }

        public Route(int routeNumber, string departureCity, string arrivalCity, List<string> viaCities, int[,] distanceMatrix,
            TravelMode mode, DateTime departureDate)
        {
            RouteNumber = routeNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            ViaCities = viaCities;
            DistanceMatrix = distanceMatrix;
            Mode = mode;
            DepartureDate = departureDate;
        }

        public enum TravelMode
        {
            Demiryolu,
            Karayolu,
            Havayolu
        }
    }
}