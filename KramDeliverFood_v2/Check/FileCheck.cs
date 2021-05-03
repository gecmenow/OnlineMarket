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

        public static void FileExist(string path)
        {
            if (!File.Exists(path))
            {
                using (var file = new FileStream(path, FileMode.Create))

                file.Close();
            }
        }
    }
}
