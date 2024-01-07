using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RezervasyonSistemi;

namespace RezervasyonSistemi
{
    public abstract class Vehicle
    {
        public string companyName { get; set; }
        public string araçId { get; set; }
        public string yakıtTürü { get; set; }
        public int kapasite { get; set; }
        public int seferNo { get; set; }
        public bool IsDeleted { get; set; }

        public abstract void CalculateFuelCost();
    }

    class Bus : Vehicle
    {
        public Bus(string companyName, string araçId, string yakıtTürü, int kapasite,int seferNo)
        {
            this.companyName = companyName;
            this.araçId = araçId;
            this.yakıtTürü = yakıtTürü;
            this.kapasite = kapasite;
            this.seferNo = seferNo;
        }


        public override void CalculateFuelCost()
        {
           
        }
    }

    class Train : Vehicle
    {
        public Train(string companyName, string araçId, string yakıtTürü, int kapasite,int seferNo)
        {
            this.companyName = companyName;
            this.araçId = araçId;
            this.yakıtTürü = yakıtTürü;
            this.kapasite = kapasite;
            this.seferNo = seferNo;
        }

        public override void CalculateFuelCost()
        {
            
        }
    }

    class Airplane : Vehicle
    {
        public Airplane(string companyName, string araçId, string yakıtTürü, int kapasite,int seferNo)
        {
            this.companyName = companyName;
            this.araçId = araçId;
            this.yakıtTürü = yakıtTürü;
            this.kapasite = kapasite;
            this.seferNo = seferNo;
        }

        public override void CalculateFuelCost()
        {
            
        }
    }
}
