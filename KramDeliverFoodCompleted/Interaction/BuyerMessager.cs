using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerMessager
    {
        public static void ShowProducts(IEnumerable<Product> products)
        {
            Console.WriteLine("We've got for you these products\n");
            var counter = 0;

            foreach (var product in products)
            {
                Console.WriteLine(counter + " - " + product.Name);
                counter++;
            }
        }

        public static void ShowOrder(IEnumerable<Product> products, OrderService order)
        {
            Console.WriteLine("You ordered these products\n");
            var counter = 0;

            foreach (var product in products)
            {
                Console.WriteLine(counter + " - " + product.Name);
                counter++;
            }

            Console.WriteLine("The products will be delivered to the person by this information. \n" +
                order.Address + "\n" +
                "We'll call you by this phone - " + order.PhoneNumber + " Thanks\n");
        }

        public static void BuyInstruction()
        {
            Console.WriteLine("\nType a serial number of the product and press Enter \n" +
                "to confirm your order\n");
        }

        public static void BuyMore()
        {
            Console.WriteLine("If you want to buy more type - y, otherwise - n\n");
        }

        public static void BuyerPhone()
        {
            Console.WriteLine("Please type your phone number in this types of formats\n" +
                "+380(xx)xxx xx xx\n" +
                "+380xxxxxxxxx\n" +
                "0xxxxxxxxx\n" +
                "0xx xxx xx xx\n");
        }

        public static void BuyerAddress()
        {
            Console.WriteLine("Please type your phone address in this types of formats\n" +
                "улица Название, д. номер, кв. номер\n" +
                "улица Назв. д.номер, кв.номер\n" +
                "ул.Назв.д.номер,кв.номер\n" +
                "ул.Назв.д.номер\n" +
                "ул.Назв.дом номер,квартира номер\n");
        }

        public static void RepeatData()
        {
            Console.WriteLine("Please repeat your data in correct format");
        }

        public static void ShowSuccessfulOrder()
        {
            Console.WriteLine("Congratulations. Your order is ready and wait for the delivering\n");
        }
    }
}
