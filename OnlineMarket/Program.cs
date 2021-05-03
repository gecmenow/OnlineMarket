using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineMarket
{
    static class Program
    {
        public static decimal InvokePriceCalculatiion()
        {
            var destinations = new[]
            {
                "949 Fairfield Court, Madison Heights, MI 48071",
                "367 Wayne Street, Hendersonville, NC 28792",
                "910 North Heather Street, Cocoa, FL 32927",
                "911 North Heather Street, Cocoa, FL 32927",
                "706 Tarkiln Hill Ave, Middleburg, FL 32068",
            };

            var clients = new[]
            {
                "Autumn Baldwin",
                "Jorge Hoffman",
                "Amiah Simmons",
                "Sariah Bennett",
                "Xavier Bowers",
            };

            var infantsIds = new[] { 2 };
            var childrenIds = new[] { 3, 4 };

            var prices = new[] { 100, 25.23m, 58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };

            return Calculator.GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
        }

        static void Main(string[] args)
        {
            var price = InvokePriceCalculatiion();

            Console.WriteLine("Full price = " + price + " USD.");

            Console.ReadKey();
        }
    }
}
