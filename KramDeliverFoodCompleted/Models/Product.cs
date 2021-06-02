﻿using KramDeliverFoodCompleted.Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KramDeliverFoodCompleted.Models
{
    public class Product
    {
        public void AddProduct(Data.Product product)
        {       
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");

            var folderPath = Path.Combine(Variables.CurrentDirectory, Variables.Folder);

            var path = Path.Combine(folderPath, Variables.BaseProducts);

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (var file = new StreamWriter(path, true)) ;

            if (!GetProducts().Any(x => x.Id == productId))
            {
                string item = product.Id + ";" + product.Name + ";" + product.Price + ";" +
                    product.Specifications + ";" + product.Description;

                File.AppendAllText(path, item + Environment.NewLine);
            }            
        }

        public IList<Data.Product> GetProducts()
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.BaseProducts);

            var items = File.ReadLines(path).ToList();

            List<Data.Product> products = new List<Data.Product>();

            foreach (var item in items)
            {
                var temp = item.Replace("(", "").Replace(")", "").Split(";");

                products.Add(new Data.Product { Id = Guid.Parse(temp[0]), Name = temp[1], Price = Decimal.Parse(temp[2]), Specifications = temp[3], Description = temp[4] });
            }

            return products;
        }  

        public bool IsRealProductId(int id)
        {
            var productsLength = GetProducts().Count;

            return id >= 0 && id < productsLength;
        }

        public Data.Product GetProductById(int id)
        {
            var products = GetProducts();

            var counter = 0;

            Data.Product product = default;

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
    }
}
