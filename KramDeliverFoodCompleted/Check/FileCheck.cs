using KramDeliverFoodCompleted.Models;
using System;
using System.IO;

namespace KramDeliverFoodCompleted.Check
{
    public class FileCheck
    {
        public static void CreateProductsFile(string path)
        {
            using var file = new StreamWriter(path, true); ;
        }
    }
}
