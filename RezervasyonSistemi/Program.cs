using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Company> companyList = new List<Company>
            {
                new Company { Username = "A", Password = "123", CompanyName = "A" },
                new Company { Username = "B", Password = "123", CompanyName = "B" },
                new Company { Username = "C", Password = "123", CompanyName = "C" },
                new Company { Username = "D", Password = "123", CompanyName = "D" },
                new Company { Username = "F", Password = "123", CompanyName = "F" }
            };

            
            Application.Run(new FormLogin(companyList));
        }
    }
}