using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class Messenger
    {
        public static void ShowWelcomeMessage()
        {
            Console.WriteLine("Hello and welcome in \" Kram Delivery Food\" \n" +
                "Tell us, who you are 1 - The Buyer, 2 - The Provider of the food. \n" +
                "Or press 3 - to exit.\n");
            Console.Write("Make your choise: ");
        }

        public static void RepeatInput()
        {
            Console.WriteLine("Please repeat input");
        }  

        public static void ShowCurrencies()
        {
            Console.Write("Type 1 or 2 or else number if you want to buy in eur/usd/uah: ");
        }

        public static void ShowByeMessage()
        {
            Console.WriteLine("Thanks for visiting");
        }
    }
}
 