using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    class Calculator
    {
        public static decimal GetFullPrice(
                                    IEnumerable<string> destinations,
                                    IEnumerable<string> clients,
                                    IEnumerable<int> infantsIds,
                                    IEnumerable<int> childrenIds,
                                    IEnumerable<decimal> prices,
                                    IEnumerable<string> currencies)
        {
            decimal fullPrice = default;

            // Your solution supposed to be here.

            //change IEnumerable to Array
            string[] destinationsArray = destinations.ToArray();
            string[] clientsArray = clients.ToArray();
            int[] infantsIdsArray = infantsIds.ToArray();
            int[] childrenIdsArray = childrenIds.ToArray();
            decimal[] pricesArray = prices.ToArray();
            string[] currenciesArray = currencies.ToArray();

            if (Validator.validateData(destinationsArray, clientsArray, pricesArray, currenciesArray))
            {
                Convertor.convertCurrencies(ref pricesArray, ref currenciesArray);
                Discount.checkStreetPrice(ref pricesArray, destinationsArray);
                Discount.CheckoutPrice(ref pricesArray, infantsIdsArray, childrenIdsArray, destinationsArray);
            }

            //Compute full price of order
            for (int i = 0; i < pricesArray.Length; i++)
                fullPrice += pricesArray[i];

            return fullPrice;
        }
    }
}
