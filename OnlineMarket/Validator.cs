using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    class Validator
    {
        public static bool validateData(string[] destinations, string[] clients, decimal[] prices, string[] currencies)
        {
            if (destinations.Length == clients.Length && prices.Length == currencies.Length)
                return true;

            return false;
        }
    }
}
