using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    class Discount
    {
        public static void checkoutPrice(ref decimal[] prices, int[] infantsIds, int[] childrenIdsArray, string[] destinationsArray)
        {
            var dicscount = 0m;

            for (int i = 0; i < infantsIds.Length; i++)
            {
                dicscount = prices[infantsIds[i]] * 50 / 100;
                prices[infantsIds[i]] -= dicscount;
            }

            for (int i = 0; i < childrenIdsArray.Length; i++)
            {
                dicscount = prices[childrenIdsArray[i]] * 25 / 100;

                prices[childrenIdsArray[i]] -= dicscount;
            }

            var sameStreets = checkSameStreets(destinationsArray);

            for (int i = 0; i < sameStreets.Length - 1; i++)
            {
                if (sameStreets[i + 1] == sameStreets[i])
                {
                    dicscount = prices[i + 1] * 15 / 100;

                    prices[i + 1] -= dicscount;
                }
            }
        }

        public static void checkStreetPrice(ref decimal[] prices, string[] destinationsArray)
        {
            for (int i = 0; i < destinationsArray.Length; i++)
            {
                if (destinationsArray[i].Contains("Wayne Street"))
                {
                    prices[i] += 10;
                    continue;
                }

                if (destinationsArray[i].Contains("North Heather Street"))
                {
                    prices[i] -= 5.36m;
                }
            }
        }

        static string[] checkSameStreets(string[] destinationsArray)
        {
            for (int i = 0; i < destinationsArray.Length; i++)
            {
                destinationsArray[i] = destinationsArray[i].Substring(destinationsArray[i].IndexOf(" "));
                destinationsArray[i] = destinationsArray[i].Substring(0, destinationsArray[i].IndexOf(","));
            }

            return destinationsArray;
        }
    }
}
