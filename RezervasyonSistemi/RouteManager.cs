using System;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonSistemi
{
    public class RouteManager
    {
        public List<Route> Routes { get; set; }
        public CompanyManager CompanyManager { get; set; }

        public RouteManager()
        {
            Routes = new List<Route>();
            CompanyManager = new CompanyManager();
            GenerateRoutes();
        }

        private void GenerateRoutes()
        {
            DateTime startDate = new DateTime(2023, 12, 4);
            DateTime endDate = new DateTime(2023, 12, 11);

            for (int i = 0; i < endDate.Subtract(startDate).Days;i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                Routes.Add(new Route(Routes.Count + 1, "Istanbul", "Ankara", new List<string> { "Kocaeli", "Bilecik", "Eskisehir" },
                    new int[,]
                    {
                        { 0, 75, 225, 375, 600, 450 },
                        { 75, 0, 75, 300, 150, 350 },
                        { 225, 75, 0, 225, 75, 300 },
                        { 375, 300, 225, 0, 150, 0 },
                        { 300, 150, 75, 150, 0, 225 },
                        { 450, 350, 300, 0, 225, 0 }
                    }, Route.TravelMode.Demiryolu, currentDate));

                Routes.Add(new Route(Routes.Count + 1, "Ankara", "Istanbul", new List<string> { "Kocaeli", "Bilecik", "Eskisehir" },
                    new int[,]
                    {
                        { 0, 75, 225, 375, 600, 450 },
                        { 75, 0, 75, 300, 150, 350 },
                        { 225, 75, 0, 225, 75, 300 },
                        { 375, 300, 225, 0, 150, 0 },
                        { 300, 150, 75, 150, 0, 225 },
                        { 450, 350, 300, 0, 225, 0 }
                    }, Route.TravelMode.Demiryolu, currentDate));

                Routes.Add(new Route(Routes.Count + 1, "Istanbul", "Konya", new List<string> { "Kocaeli", "Bilecik", "Eskisehir" },
                    new int[,]
                    {
                        { 0, 75, 225, 375, 600, 450 },
                        { 75, 0, 75, 300, 150, 350 },
                        { 225, 75, 0, 225, 75, 300 },
                        { 375, 300, 225, 0, 150, 0 },
                        { 300, 150, 75, 150, 0, 225 },
                        { 450, 350, 300, 0, 225, 0 }
                    }, Route.TravelMode.Demiryolu, currentDate));

                Routes.Add(new Route(Routes.Count + 1, "Konya", "Istanbul", new List<string> { "Kocaeli", "Bilecik", "Eskisehir" },
                    new int[,]
                    {
                        { 0, 75, 225, 375, 600, 450 },
                        { 75, 0, 75, 300, 150, 350 },
                        { 225, 75, 0, 225, 75, 300 },
                        { 375, 300, 225, 0, 150, 0 },
                        { 300, 150, 75, 150, 0, 225 },
                        { 450, 350, 300, 0, 225, 0 }
                    }, Route.TravelMode.Demiryolu, currentDate));

                Routes.Add(new Route(Routes.Count + 1, "Istanbul", "Ankara", new List<string>(),
                    new int[,]
                    {
                        { 0, 250, 300 },
                        { 250, 0, 0 },
                        { 300, 0, 0 },
                    }, Route.TravelMode.Havayolu, currentDate));

                
                Routes.Add(new Route(Routes.Count + 1, "Istanbul", "Konya", new List<string>(),
                    new int[,]
                    {
                        { 0, 250, 300 },
                        { 250, 0, 0 },
                        { 300, 0, 0 },
                    }, Route.TravelMode.Havayolu, currentDate));
            }
        }

        public List<string> GetAllCities()
        {
            List<string> allCities = new List<string>();

            foreach (var route in Routes)
            {
                allCities.Add(route.DepartureCity);

                foreach (var viaCity in route.ViaCities)
                {
                    if (!allCities.Contains(viaCity))
                    {
                        allCities.Add(viaCity);
                    }
                }

                allCities.Add(route.ArrivalCity);
            }

            return allCities.Distinct().ToList();
        }
    }
}
