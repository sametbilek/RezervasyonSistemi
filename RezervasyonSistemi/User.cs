using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace RezervasyonSistemi
{
    public abstract class User :Person, ILoginable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }
    }

    public class Admin : User
    {

        public Admin()
        {
            Username = "admin";
            Password = "admin";
        }
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

    }

    public class Company : User, IProfitable
    {
        public string CompanyName { get; set; }
        
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }


        public decimal CalculateDailyProfit()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateOverallProfit()
        {
            throw new NotImplementedException();
        }
    }
    }


