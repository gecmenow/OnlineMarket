using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Models
{
    public class ProductSaver
    {
        public void ProductsFileSave(Data.Product product)
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            string item = product.Id + ";" + product.Name + ";" + product.Price + ";" + product.Specifications + ";" + product.Description;

            File.AppendAllText(path, item + Environment.NewLine);
        }
    }
}
