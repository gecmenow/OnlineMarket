using Dapper;
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
    public class Repository : IRepository
    {
        private IDbConnection db;

        public Repository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }
        public Guid AddProducts(Product provider)
        {
            throw new NotImplementedException();
        }

        public Guid DeleteProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(Guid id)
        {
            var sql = "SELECT * from Products " +
            "WHERE Products.ProductID = @id";

            return db.Query<Product>(sql, new { id = id }).SingleOrDefault();
        }

        public Product GetCategoryWithProductsById(Guid id)
        {
            var sql = "SELECT * " +
                    "FROM Categories " +
                    "INNER JOIN Products ON Categories.CategoryID = Products.CategoryID " +
                    "WHERE Categories.CategoryID = @id ";

            return db.Query<Product>(sql, new { id = id }).SingleOrDefault();
        }

        public List<Product> GetProducts()
        {
            var sql = "SELECT *" +
                   "FROM Products";

            List<Product> list = db.Query<Product>(sql).ToList();
            return list;
        }

        public List<Product> GetNestedProducts()
        {
            var sql = "SELECT *" +
                   "FROM Categories" +
                   "INNER JOIN Products ON Categories.CategoryID = Products.ProductID";

            return db.Query<List<Product>>(sql).SingleOrDefault();
        }

        public Guid UpdateProducts(Product provider)
        {
            throw new NotImplementedException();
        }
    }
}
