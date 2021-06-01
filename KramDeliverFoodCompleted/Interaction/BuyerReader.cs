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
                        Messager.RepeatInput();

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

            while(!IsBuyMoreProducts(input))
            {
                Messager.RepeatInput();

                input = Console.ReadLine();
            }

            if (IsBuyMoreProducts(input))
                return true;

            return false;
        }

        ///<summary>
        ///This method is checinkg user input for buying more products
        ///and expecting y or n incoming.
        ///</summary>
        private static bool IsBuyMoreProducts(string input)
        {
            return (input == "y" || input == "n") ? true : false;
        }

        public static string EnterPhoneNumber()
        {
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) == false)
            {
                Messager.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }

        public static string EnterAddress()
        {
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) == false)
            {
                Messager.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }
    }
}
