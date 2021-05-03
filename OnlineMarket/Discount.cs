using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    class Discount
    {
        public static void CheckoutPrice(ref decimal[] prices, int[] infantsIds, int[] childrenIds, string[] destinations)
        {
            var disccount = 0m;

            for (int i = 0; i < infantsIds.Length; i++)
            {
                disccount = prices[infantsIds[i]] * 50 / 100;
                prices[infantsIds[i]] -= disccount;
            }

            for (int i = 0; i < childrenIds.Length; i++)
            {
                disccount = prices[childrenIds[i]] * 25 / 100;

                prices[childrenIds[i]] -= disccount;
            }

            var streetsWithoutHiuseNumbers = RemoveHouseNumbers(destinations);

            for (int i = 0; i < streetsWithoutHiuseNumbers.Length - 1; i++)
            {
                if (streetsWithoutHiuseNumbers[i + 1] == streetsWithoutHiuseNumbers[i])
                {
                    disccount = prices[i + 1] * 15 / 100;

                    prices[i + 1] -= disccount;
                }
            }
        }

        public static void CheckStreetPrice(ref decimal[] prices, string[] destinations)
        {
            for (int i = 0; i < destinations.Length; i++)
            {
                if (destinations[i].Contains("Wayne Street"))
                {
                    prices[i] += 10;
                    continue;
                }

                if (destinations[i].Contains("North Heather Street"))
                {
                    prices[i] -= 5.36m;
                }
            }
        }

        static string[] RemoveHouseNumbers(string[] destinations)
        {
            for (int i = 0; i < destinations.Length; i++)
            {
                destinations[i] = destinations[i].Substring(destinations[i].IndexOf(" "));
                destinations[i] = destinations[i].Substring(0, destinations[i].IndexOf(","));
            }

            return destinations;
        }
    }
}
