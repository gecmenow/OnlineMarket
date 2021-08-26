﻿using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);
        IList<Product> GetProducts();
        bool IsRealProductId(int input);
        Product GetProductById(int input);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        IList<KramDelivery.Structure.Models.Product> GetProductsForApi();
        void AddProduct(KramDelivery.Structure.Models.Product product);
        void UpdateProduct(KramDelivery.Structure.Models.Product product);
        void DeleteProduct(KramDelivery.Structure.Models.Product product);
    }
}
