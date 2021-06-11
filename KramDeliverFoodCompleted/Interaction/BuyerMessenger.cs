﻿using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerMessenger
    {
        public static void ShowBuyerProducts(IEnumerable<Product> products)
        {
            Console.WriteLine("\nWe've got for you these products\n");
            var counter = 0;

            foreach (var product in products)
            {
                Console.WriteLine(counter + " - " + product.Name);
                counter++;
            }
        }

        public static void ShowBuyerOrders(IList<Order> orders)
        {
            Console.WriteLine("\nYou ordered these products\n");
            var counter = 0;

            foreach (var order in orders)
            {
                foreach (var product in order.OrderProducts)
                {
                    Console.WriteLine(counter + " - " + product.Name);
                    counter++;
                }

                Console.WriteLine("\nThe products will be delivered to the person by this information. \n" +
                    order.Address + "\n" +
                    "We'll call you by this phone - " + order.PhoneNumber + " Thanks\n");
            }
        }

        public static void ShowBuyInstruction()
        {
            Console.WriteLine("\nType a serial number of the product and press Enter \n" +
                "to confirm your order\n");
        }

        public static void ShowWrongInputMessage()
        {
            Console.WriteLine("Please, type a correct value");
        }

        public static void ShowBuyMoreMessage()
        {
            Console.WriteLine("\nIf you want to buy more type - y, otherwise - n\n");
        }

        public static void ShowAddPhoneMessage()
        {
            Console.WriteLine("\nPlease type your phone number\n");
        }

        public static void ShowAddAddressMessage()
        {
            Console.WriteLine("\nPlease type your address\n");
        }

        public static void ShowSuccessfulOrder()
        {
            Console.WriteLine("\nCongratulations. Your order is ready and wait for the delivering\n");
        }
    }
}
