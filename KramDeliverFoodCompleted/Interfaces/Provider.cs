using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;

namespace KramDeliverFoodCompleted.Interfaces
{
    public class Provider
    {
        public void AddProduct()
        {
            ProviderMessage.AddProduct();

            var providerReader = new ProviderReader();

            var newProduct = providerReader.InputProductFields();

            var product = new Product();
            product.AddProduct(newProduct);
        }
    }
}
