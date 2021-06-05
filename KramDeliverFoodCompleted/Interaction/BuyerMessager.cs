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

        public static void ShowOrders(IList<Order> orders)
        {
            Console.WriteLine("You ordered these products\n");
            var counter = 0;

            foreach (var order in orders)
            {
                foreach (var product in order.OrderProducts)
                {
                    Console.WriteLine(counter + " - " + product.Name);
                    counter++;
                }

                Console.WriteLine("The products will be delivered to the person by this information. \n" +
                    order.Address + "\n" +
                    "We'll call you by this phone - " + order.PhoneNumber + " Thanks\n");
            }
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
            Console.WriteLine("Please type your phone number\n");
        }

        public static void BuyerAddress()
        {
            Console.WriteLine("Please type your address");
        }

        public static void ShowSuccessfulOrder()
        {
            Console.WriteLine("Congratulations. Your order is ready and wait for the delivering\n");
        }
    }
}
