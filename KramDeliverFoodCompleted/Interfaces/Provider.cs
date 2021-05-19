using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;

namespace KramDeliverFoodCompleted.Interfaces
{
    public class Provider
    {
        private Product _product;

        public Provider(Product product)
        {
            _product = product;
        }

        public void AddProduct()
        {
            ProviderMessage.AddProduct();

            var providerReader = new ProviderReader();

            var newProduct = providerReader.InputProductFields();

            _product.AddProduct(newProduct);
        }
    }
}
