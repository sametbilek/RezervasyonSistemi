using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class CompanyManager:Vehicle
    {
        public List<Vehicle> CompanyVehicles { get; set; }
        public List<Personel> CompanyPersonnel { get; set; }

        public CompanyManager()
        {
            CompanyVehicles = new List<Vehicle>();
            CompanyPersonnel = new List<Personel>();
            AddDefaultVehicles();
        }


        public void AddDefaultVehicles()
        {
            CompanyVehicles.Add(new Bus("A", "ABus1", "benzin", 20, 3));
            CompanyVehicles.Add(new Bus("A", "ABus2", "benzin", 15, 3));
            CompanyVehicles.Add(new Bus("B", "BBus1", "motorin", 15, 3));
            CompanyVehicles.Add(new Bus("B", "BBus2", "motorin", 20, 4));
            CompanyVehicles.Add(new Bus("C", "CBus1", "motorin", 20, 4));
            CompanyVehicles.Add(new Airplane("C", "CAirplane1", "gaz", 30, 5));
            CompanyVehicles.Add(new Airplane("C", "CAirplane2", "gaz", 30, 5));
            CompanyVehicles.Add(new Train("D", "DTrain1", "elektrik", 25, 1));
            CompanyVehicles.Add(new Train("D", "DTrain2", "elektrik", 25, 2));
            CompanyVehicles.Add(new Train("D", "DTrain3", "elektrik", 25, 2));
            CompanyVehicles.Add(new Airplane("F", "FAirplane1", "gaz", 30, 6));
            CompanyVehicles.Add(new Airplane("F", "FAirplane2", "gaz", 30, 6));


        }


        public void AddVehicle(string companyName, string vehicleName)
        {
            var companyVehicles = CompanyVehicles.Where(v => v.companyName == companyName).ToList();

            int lastVehicleNumber = 0;
            if (companyVehicles.Any())
            {
                var lastVehicle = companyVehicles.OrderByDescending(v => int.Parse(v.araçId.Substring(v.araçId.Length - 1))).First();
                lastVehicleNumber = int.Parse(lastVehicle.araçId.Substring(lastVehicle.araçId.Length - 1));
            }
            string newVehicleId = $"{companyName}Bus{lastVehicleNumber + 1}";
            CompanyVehicles.Add(new Bus(companyName, newVehicleId, "benzin", 20, 3));
        }

        public void RemoveVehicle(string vehicleId)
        {
            var vehicleToRemove = CompanyVehicles.FirstOrDefault(v => v.araçId == vehicleId);

            if (vehicleToRemove != null)
            {
                CompanyVehicles.Remove(vehicleToRemove);
            }
        }


        public override void CalculateFuelCost()
        {
            throw new NotImplementedException();
        }
    }
}
