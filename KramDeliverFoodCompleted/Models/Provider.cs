using KramDeliverFoodCompleted.Interaction;
namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        private readonly ProviderReader _providerReader;
        private readonly Product _product;
        private readonly Reporter _reporter;

        public Provider(ProviderReader providerReader, Product product, Reporter reporter)
        {
            _providerReader = providerReader;
            _product = product;
            _reporter = reporter;
        }

        public void AddProduct()
        {
            var newProduct = _providerReader.InputProductFields();

            _product.AddProduct(newProduct);

            _reporter.AddedProduct(newProduct);

            ProviderMessage.ProductAdded();
        }
    }
}
