using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Models;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerReader:Reader
    {
        private readonly Product _product;

        public BuyerReader(Product product)
        {
            _product = product;
        }

        public override int MakeInput()
        {
            var result = 0;

            while (true)
            {
                var input = Console.ReadLine();

                var productsCount = _product.GetProducts().Count;

                if (int.TryParse(input, out result))
                {
                    if (result > 0 && result <= productsCount)
                    {
                        Logger.RepeatInput();

                        continue;
                    }

                    break;
                }
            }

            return result;
        }

        public static bool BuyMoreProducts()
        {
            BuyerMessage.BuyMore();

            var input = Console.ReadLine();

            while(!Checker.IsBuyMoreProducts(input))
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            if (Checker.IsBuyMoreProducts(input))
                return true;

            return false;
        }

        public static string EnterPhoneNumber()
        {
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) == false)
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }

        public static string EnterAddress()
        {
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) == false)
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }
    }
}
