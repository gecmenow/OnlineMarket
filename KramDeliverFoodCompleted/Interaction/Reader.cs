using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class Reader
    {
        public virtual int MakeInput()
        {
            var result = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    if (input.Length != 1)
                    { 
                        Messenger.RepeatInput();
                        continue;
                    }

                    break;
                }
            }

            return result;
        }

        public static bool BuyMoreProducts()
        {
            BuyerMessenger.BuyMore();
            var input = Console.ReadLine();

            while (input != "y" && input != "n")
            {
                Messenger.RepeatInput();

                input = Console.ReadLine();
            }

            return input == "y";
        }
    }
}
