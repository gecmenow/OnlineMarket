using KramDeliverFoodCompleted.Interaction;
namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        public void AddProduct()
        {
            var provider = new ProviderReader();

            var newProduct = provider.InputProductFields();

            var product = new Product();
            product.AddProduct(newProduct);

            ProviderMessage.ProductAdded();
        }
    }
}
