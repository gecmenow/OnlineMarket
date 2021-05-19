using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Models
{
    public class Variables
    {
        public static string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public const string Folder = "Data";
        public const string ProductsForOrder = "ProductsForOrder.csv";
        public const string BaseProducts = "Products.csv";
        public static string LogOrderProduct = "LogOrderProduct" + string.Empty + DateTime.Now.Date.AddDays(1).ToShortDateString() + ".txt";
        public static string LogAddNewProduct = "LogAddNewProduct" + string.Empty + DateTime.Now.Date.AddDays(1).ToShortDateString() + ".txt";
    }
}
