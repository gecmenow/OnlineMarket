using Dapper.Contrib.Extensions;
using KramDeliveryFood_v3.Interfaces;
using KramDeliveryFood_v3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliveryFood_v3.Repositories
{
    public class RepositoryContrib : IRepository
    {
        private IDbConnection db;

        public RepositoryContrib(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

        public void AddProductByCategory(Product product, Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            db.Insert(new Product
            {
               ProductId = product.ProductId,
               Name = product.Name,
               CategoryId = product.CategoryId,
               CategoryName = product.CategoryName,
               Price = product.Price,
               Specifications = product.Specifications,
               Description = product.Description,
               ProductType = product.ProductType,
               ProviderId = product.ProviderId,
            });
        }

        public void DeleteProduct(Product product)
        {
            db.Delete(product);
        }

        public void DeleteProductByCategory(Product product, Guid id)
        {
            throw new NotImplementedException();
        }

        public Product GetCategoryWithProductsById(Guid ProductId)
        {
            var result = db.Get<Product>(ProductId);

            return result;
        }

        public Product GetProductById(Guid ProductId)
        {
            var result = db.Get<Product>(ProductId);

            return result;
        }

        public IList<Product> GetProducts()
        {
            var result = db.GetAll<Product>().ToList();

            return result;
        }

        public void UpdateProduct(Product product)
        {
            db.Update(product);
        }

        public void UpdateProductByCategory(Product product, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
