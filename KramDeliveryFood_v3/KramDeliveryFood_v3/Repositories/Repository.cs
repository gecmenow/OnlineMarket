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
        public void AddProduct(Product product)
        {
            var sql = "INSERT INTO [dbo].[Products]([ProductID], [Name], [CategoryId], [CategoryName], [ProviderId], [Price], [Specifications], [Description], [ProductType]) " +
                "VALUES " +
                "(@ProductId, @Name, @CategoryId, "+
                "@CategoryName, @ProviderId, @Price,"+ 
                "@Specifications, @Description, @ProductType)";

            db.Execute(sql, new
            {
                product.ProductId,
                product.Name,
                product.CategoryId,
                product.CategoryName,
                product.ProviderId,
                product.Price,
                product.Specifications,
                product.Description,
                product.ProductType,
            });
        }

        public void AddProductByCategory(Product product, Guid id)
        {
            var sqlCategoryName = "SELECT CategoryName " +
                "FROM Categories " +
                "WHERE Categories.CategoryID = @id";
            var categoryName = db.QueryFirstOrDefault<string>(sqlCategoryName, new { id });
            var sql =
                "INSERT INTO [dbo].[Products]([ProductID], [Name], [CategoryId], [CategoryName], [ProviderId], [Price], [Specifications], [Description], [ProductType])" +
                "VALUES " +
                "(@ProductId, @Name, @CategoryId, " +
                "@CategoryName, @ProviderId, @Price," +
                "@Specifications, @Description, @ProductType)";

            db.Execute(sql, new
            {
                product.ProductId,
                product.Name,
                product.CategoryId,
                categoryName,
                product.ProviderId,
                product.Price,
                product.Specifications,
                product.Description,
                product.ProductType,
            });
        }

        public void DeleteProduct(Guid ProductId)
        {
            var sql = "DELETE FROM [dbo].[Products] WHERE ProductId = @ProductId";

            db.Execute(sql, new
            {
                ProductId,
            });
        }

        public void DeleteProductByCategory(Guid ProductId, Guid CategoryId)
        {
            var sqlCategoryName = "SELECT CategoryName " +
                "FROM Categories " +
                "WHERE Categories.CategoryID = @CategoryId";
            var categoryName = db.QueryFirstOrDefault<string>(sqlCategoryName, new { CategoryId });

            var sql = "DELETE FROM [dbo].[Products] WHERE ProductId = @ProductId AND CategoryName = @categoryName";

            db.Execute(sql, new
            {
                ProductId,
                categoryName
            });
        }

        public Product GetProductById(Guid id)
        {
            var sql = "SELECT * from Products " +
            "WHERE Products.ProductID = @id";

            return db.Query<Product>(sql, new { id }).SingleOrDefault();
        }

        public Product GetCategoryWithProductsById(Guid id)
        {
            var sql = "SELECT * " +
                    "FROM Categories " +
                    "INNER JOIN Products ON Categories.CategoryID = Products.CategoryID " +
                    "WHERE Categories.CategoryID = @id ";

            return db.Query<Product>(sql, new { id }).FirstOrDefault();
        }

        public IList<Product> GetProducts()
        {
            var sql = "SELECT *" +
                   "FROM Products";

            IList<Product> list = db.Query<Product>(sql).ToList();
            return list;
        }

        public List<Product> GetNestedProducts()
        {
            var sql = "SELECT *" +
                   "FROM Categories" +
                   "INNER JOIN Products ON Categories.CategoryID = Products.ProductID";

            return db.Query<List<Product>>(sql).SingleOrDefault();
        }

        public void UpdateProduct(Product product)
        {
            var sql = "UPDATE Products " +
                "SET Name = @Name " +
                "WHERE ProductId = @ProductId";

                db.Execute(sql, new
                {
                    product.Name,
                    product.ProductId,
                });
        }

        public void UpdateProductByCategory(Product product, Guid Categoryid)
        {
            var sqlCategoryName = "SELECT CategoryName " +
                "FROM Categories " +
                "WHERE Categories.CategoryID = @Categoryid";
            var categoryName = db.QueryFirstOrDefault<string>(sqlCategoryName, new { Categoryid });

            var sql = "UPDATE Products " +
                "SET Name = @Name " +
                "WHERE CategoryName = @categoryName";

            db.Execute(sql, new
            {
                product.Name,
                categoryName,
            });
        }
    }
}
