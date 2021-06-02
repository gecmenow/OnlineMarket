using KramDeliverFoodCompleted.Interaction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Models
{
    public class Order
    {
        private readonly Product _product;

        private readonly ProductSaver _productSaver;

        private readonly Checkout _checkout;
        public Order(Product product, ProductSaver productSaver, Checkout checkout)
        {
            _product = product;
            _productSaver = productSaver;
            _checkout = checkout;
        }

        public void MakeCheckout(IEnumerable<Data.Product> products, string phoneNumber, string address)
        {
            _checkout.Order = products;
            _checkout.Address = address;
            _checkout.PhoneNumber = phoneNumber;

            BuyerMessager.MakeOrder(_checkout, address, phoneNumber);

            BuyerMessager.ShowSuccessfulOrder();
        }

        public void AddProductToOrder(int productId)
        {
            var product = _product.GetProductById(productId);

            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            using (var file = new StreamWriter(path, true)) ;

            _productSaver.ProductsFileSave(product);
        }

        public IList<Data.Product> GetOrderedProducts()
        {
            var path = Path.Combine(Variables.CurrentDirectory, Variables.Folder, Variables.ProductsForOrder);

            var items = File.ReadLines(path).ToList();

            List<Data.Product> products = new List<Data.Product>();

            foreach (var item in items)
            {
                var temp = item.Replace("(", "").Replace(")", "").Split(";");

                products.Add(new Data.Product { Id = Guid.Parse(temp[0]), Name = temp[1], Price = Decimal.Parse(temp[2]), Specifications = temp[3], Description = temp[4] });
            }

            File.Delete(path);

            return products;
        }
    }
}
