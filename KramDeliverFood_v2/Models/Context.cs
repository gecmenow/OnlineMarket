using KramDeliverFoodCompleted.Check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Models
{
    public class Context
    {
        public void SaveProductToFile(Product product)
        {
            FileCheck.ProductsFileExist();
            FileCheck.ProductsFileSave(product);
        }

        public void ReadFromFile()
        {

        }
    }
}

