using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerMessenger
    {
        public static void ShowBuyerProducts(IEnumerable<Products> products)
        {
            Console.WriteLine("We've got for you these products\n");
            var counter = 0;

            foreach (var product in products)
            {
                Console.WriteLine(counter + " - " + product.Name);
                counter++;
            }
        }

        public static void ShowBuyerOrders(IList<Orders> orders)
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
            Console.WriteLine("Please type your phone number in this types of formats\n" +
                "+380(xx)xxx xx xx\n" +
                "+380xxxxxxxxx\n" +
                "0xxxxxxxxx\n" +
                "0xx xxx xx xx\n");
        }

        public static void ShowAddAddressMessage()
        {
            Console.WriteLine("Please type your phone address in this types of formats\n" +
                "улица Название, д. номер, кв. номер\n" +
                "улица Назв. д.номер, кв.номер\n" +
                "ул.Назв.д.номер,кв.номер\n" +
                "ул.Назв.д.номер\n" +
                "ул.Назв.дом номер,квартира номер\n");
        }

        public static void ShowRepeatData()
        {
            Console.WriteLine("Please repeat your data in correct format");
        }

        public static void ShowSuccessfulOrder()
        { 
            Console.WriteLine("Congratulations. Your order is ready and wait for the delivering\n");
        }
    }
}
