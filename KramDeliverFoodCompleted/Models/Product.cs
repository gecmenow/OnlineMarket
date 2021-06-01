using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KramDeliverFoodCompleted.Models
{
    public class Product : BaseProduct
    {
        public void InitProducts()
        {
            var products = new List<Product>();

            products.Add(new Product { Id = Guid.Parse("db7fc833-bed5-4dab-b220-dc54a769839b"), Name = "Омлет доброе утро", Price = 80.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы" });
            products.Add(new Product { Id = Guid.Parse("2361e2c1-51b3-4dbb-af95-3adfcbfd3fdd"), Name = "Сырники творожные со сметаной", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана" });
            products.Add(new Product { Id = Guid.Parse("dc5df95a-16ef-4dd2-9ebf-68c2074388db"), Name = "Каша рисовая молочная", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар" });

            foreach (var product in products)
            {
                AddProduct(product);
            }
        }

        public void AddProduct(Product product)
        {       
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");

            var folderPath = Path.Combine(Variables.CurrentDirectory, Variables.Folder);

            var path = Path.Combine(folderPath, Variables.BaseProducts);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var file = new StreamWriter(path, true)) ;

            if (isProductExist(product.Id) == false)
            {
                string item = product.Id + ";" + product.Name + ";" + product.Price + ";" +
                    product.Specifications + ";" + product.Description;

                File.AppendAllText(path, item + Environment.NewLine);
            }            
        }

        public static IList<Product> ReadBaseProducts()
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.BaseProducts);

            var items = File.ReadLines(path).ToList();

            List<Product> products = new List<Product>();

            foreach (var item in items)
            {
                var temp = item.Replace("(", "").Replace(")", "").Split(";");

                products.Add(new Product { Id = Guid.Parse(temp[0]), Name = temp[1], Price = Decimal.Parse(temp[2]), Specifications = temp[3], Description = temp[4] });
            }

            return products;
        }

        public static void ProductsFileSave(Product product)
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            string item = product.Id + ";" + product.Name + ";" + product.Price + ";" + product.Specifications + ";" + product.Description;

            File.AppendAllText(path, item + Environment.NewLine);

        }

        public static IList<Product> ReadProductsForOrder()
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

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

        public IList<Product> GetProducts()
        {
            var products = new List<Product>();

            products = (List<Product>)ReadBaseProducts();

            return products;
        }

        public IEnumerable<string> GetProductsNamespaces()
        {
            var productNamespaces = new List<string>();

            productNamespaces.Add("Name");
            productNamespaces.Add("Price");
            productNamespaces.Add("Specifications");
            productNamespaces.Add("Description");

            return productNamespaces;
        }

        public Product GetProduct(int id)
        {
            var products = GetProducts();

            var counter = 0;

            Product product = default;

            foreach (var item in products)
            {
                if (counter == id)
                {
                    product = item;
                }

                counter++;
            }

            return product;
        }

        public void AddProductToOrder(Product product)
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            using (var file = new StreamWriter(path, true)) ;

            ProductsFileSave(product); 
        }

        public IList<Product> GetOrderedProducts()
        {
            var products = ReadProductsForOrder();

            return products;
        }

        private bool isProductExist(Guid productId)
        {
            var products = GetProducts();

            foreach (var item in products)
            {
                if (item.Id == productId)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
