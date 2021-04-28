using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Check
{
    public class FileCheck
    {
        public static void ProductsFileExist()
        {
            var path = Path.Combine(Environment.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            if (!File.Exists(path))
                using (FileStream file = new FileStream(path, FileMode.Create))
                    file.Close();
        }

        public static bool BaseProductsFileExist()
        {
            var path = Path.Combine(Environment.CurrentDirectory, Variables.Folder, Variables.BaseProducts);

            if (File.Exists(path))
                return true;

            return false;
        }

        public static void SaveBaseProducts(IList<Product> products)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");

            var folderPath = Path.Combine(Environment.CurrentDirectory, Variables.Folder);

            var path = Path.Combine(folderPath, Variables.BaseProducts);

            FolderCheck.FolderExist(folderPath);

            using (FileStream file = new FileStream(path, FileMode.Create))
                file.Close();

            foreach (var product in products)
            {
                String item = product.Id + ";" + product.Name + ";" + product.Price + ";" +
                    product.Specifications + ";" + product.Description;

                File.AppendAllText(path, item + Environment.NewLine);
            }
        }

        public static IList<Product> ReadBaseProducts()
        {
            var path = Path.Combine(Environment.CurrentDirectory, Variables.Folder, Variables.BaseProducts);

            var items = File.ReadLines(path).ToList();

            List<Product> products = new List<Product>();

            foreach(var item in items)
            {
                var temp = item.Replace("(", "").Replace(")", "").Split(";");

                products.Add(new Product { Id = Guid.Parse(temp[0]), Name = temp[1], Price = Decimal.Parse(temp[2]), Specifications = temp[3], Description = temp[4]});
            }

            return products;
        }

        public static void ProductsFileSave(Product product)
        {
            var path = Path.Combine(Environment.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            String item = product.Id + ";" + product.Name + ";" + product.Price + ";" + product.Specifications + ";" + product.Description;

            File.AppendAllText(path, item + Environment.NewLine);
            
        }

        public static IList<Product> ReadProductsForOrder()
        {
            var path = Path.Combine(Environment.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            var items = File.ReadLines(path).ToList();

            List<Product> products = new List<Product>();

            foreach (var item in items)
            {
                var temp = item.Replace("(", "").Replace(")", "").Split(";");

                products.Add(new Product { Id = Guid.Parse(temp[0]), Name = temp[1], Price = Decimal.Parse(temp[2]), Specifications = temp[3], Description = temp[4] });
            }

            File.Delete(path);

            return products;
        }
    }
}
