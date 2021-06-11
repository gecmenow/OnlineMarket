using System;
using System.Reflection;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderMessenger
    {
        public static void AddProduct()
        {
            Console.WriteLine("Please fill inputs to add a product to our data base.\n" +
                "After filling press Enter");
        }

        public static void ProductAdded()
        {
            Console.WriteLine("Your product is sucessfully added to the data base.Thanks!");
        }

        public static void ShowInputProductField(PropertyInfo product)
        {
            var temp = product + " = ";
            Console.Write(temp);
        }
    }
}
