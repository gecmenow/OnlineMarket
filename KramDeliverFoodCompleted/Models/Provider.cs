using KramDeliverFoodCompleted.Interaction;
namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        private readonly ProviderReader _providerReader;

        public Provider(ProviderReader providerReader)
        {
            _providerReader = providerReader;
        }
        public void AddProduct()
        {
            var newProduct = _providerReader.InputProductFields();

            var product = new Product();
            product.AddProduct(newProduct);

            ProviderMessage.ProductAdded();
        }
    }
}
