using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public abstract class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
    }

    public class Personel :Person
    {
        public Personel(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    class Passenger :Person
    {
        public Passenger(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
