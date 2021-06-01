using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderMessage
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

        public static void ShowInputProductField(string product)
        {
            var temp = product + " = ";
            Console.Write(temp);
        }
    }
}
