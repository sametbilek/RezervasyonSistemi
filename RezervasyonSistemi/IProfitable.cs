using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    internal interface IProfitable
    {
        decimal CalculateDailyProfit();
        decimal CalculateOverallProfit();
    }
}
