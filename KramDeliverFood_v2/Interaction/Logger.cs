﻿using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class Logger
    {
        public static void WelcomeMessage()
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

        public static void ByeMessage()
        {
            Console.WriteLine("Thanks for visiting");
        }


        public static void ExceptionMessage(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
