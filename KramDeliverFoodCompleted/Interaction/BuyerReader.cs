using KramDeliverFoodCompleted.Check;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerReader
    {
        public static int UserChoice()
        {
            var input = Console.ReadLine();

<<<<<<< HEAD
            while (!Checker.EmptyUserInput(input) && !Checker.NonStringUserInput(input) && !Checker.UserLengthInput(input))
=======
            while (!Checker.EmptyUserInput(input) && !Checker.NonLetterUserInput(input) && !Checker.UserLengthInput(input))
>>>>>>> task_3
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

<<<<<<< HEAD
            var result = Converter.Converter.UserInput(input);
=======
            int.TryParse(input, out var result);
>>>>>>> task_3

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

<<<<<<< HEAD
            while (!Checker.EmptyUserInput(input) == false && BuyerInfoChecker.CheckPhone(input) == false)
=======
            while (Checker.EmptyUserInput(input) == false)
>>>>>>> task_3
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }

        public static string Address()
        {
            var input = Console.ReadLine();

<<<<<<< HEAD
            while (!Checker.EmptyUserInput(input) && BuyerInfoChecker.CheckAddress(input))
=======
            while (!Checker.EmptyUserInput(input))
>>>>>>> task_3
            {
                Logger.RepeatInput();

                input = Console.ReadLine();
            }

            return input;
        }
    }
}
