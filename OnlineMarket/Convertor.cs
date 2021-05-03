using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    class Converter
    {
        public static void ConvertCurrencies(ref decimal[] prices, ref string[] currencies)
        {
            for (int i = 0; i < currencies.Length; i++)
            {
                if (currencies[i] == "EUR")
                {
                    currencies[i] = "USD";
                    prices[i] *= 1.19m;
                }
            }
        }
    }
}
