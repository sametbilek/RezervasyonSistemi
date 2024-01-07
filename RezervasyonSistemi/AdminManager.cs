using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal class AdminManager
    {
        public List<Company> companies;
        public List<Admin> admins;

        public AdminManager(List<Company> companies, List<Admin> admins)
        {
            this.companies = companies;
            this.admins = admins;
        }

        public void AddCompany(Company newCompany)
        {
          
            companies.Add(newCompany);
        }

        public void RemoveCompany(Company companyToRemove)
        {
            companies.Remove(companyToRemove);
        }
    }
}
