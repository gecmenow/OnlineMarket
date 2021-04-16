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

            var adress = destinations.ToArray();
            var clientsInfo = clients.ToArray();
            var infantsIdNumbers = infantsIds.ToArray();
            var childrenIdNumbers = childrenIds.ToArray();
            var orderPrices = prices.ToArray();
            var orderCurrencies = currencies.ToArray();

            if (Validator.ValidateData(adress, clientsInfo, orderPrices, orderCurrencies))
            {
                Converter.ConvertCurrencies(ref orderPrices, ref orderCurrencies);
                Discount.CheckStreetPrice(ref orderPrices, adress);
                Discount.CheckoutPrice(ref orderPrices, infantsIdNumbers, childrenIdNumbers, adress);
            }

            for (int i = 0; i < orderPrices.Length; i++)
                fullPrice += orderPrices[i];

            return fullPrice;
        }
    }
}
