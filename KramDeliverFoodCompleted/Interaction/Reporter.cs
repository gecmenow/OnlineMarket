using KramDeliverFoodCompleted.Models;
using System;
using System.IO;

namespace KramDeliverFoodCompleted.Interaction
{
    public class Reporter
    {
        public void OrderedProduct(Product product)
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.LogOrderProduct);

            using var file = new StreamWriter(path, true);

            file.WriteLine($"Added Id: " + product.Id + " Date: " + DateTime.Now);
        }

        public void AddedProduct(Product product)
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.LogAddNewProduct);

            using var file = new StreamWriter(path, true);

            file.WriteLine($"Added Id: " + product.Id + " Date: " + DateTime.Now);
        }
    }
}
