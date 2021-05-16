using KramDeliverFoodCompleted.Check;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerReader
    {
        public static int UserChoice()
        {
            var input = Console.ReadLine();

            while (!Checker.EmptyUserInput(input) && !Checker.NonLetterUserInput(input) && !Checker.UserLengthInput(input))
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            int.TryParse(input, out var result);

            return result;
        }

        public static bool BuyMoreProducts()
        {
            BuyerMessage.BuyMore();

            var input = Console.ReadLine();

            while(!Checker.BuyMoreProductsCorrect(input))
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            if (Checker.BuyMoreProducts(input))
                return true;

            return false;
        }

        public static string PhoneNumber()
        {
            var input = Console.ReadLine();

            while (Checker.EmptyUserInput(input) == false)
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }

        public static string Address()
        {
            var input = Console.ReadLine();

            while (!Checker.EmptyUserInput(input))
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }
    }
}
