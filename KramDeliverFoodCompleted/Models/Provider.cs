using KramDeliverFoodCompleted.Interaction;
using System;

namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        private readonly ProviderReader _providerReader;
        private readonly Product _product;

        public Provider(Product product, ProviderReader providerReader)
        {
            _providerReader = providerReader;
            _product = product;
        }
        public void AddProduct()
        {
            var newProduct = _providerReader.InputProductFields();

            _product.Id = new Guid();
            _product.Name = newProduct[0];
            _product.Price = Convert.ToDecimal(newProduct[1]);
            _product.Specifications = newProduct[2];
            _product.Description = newProduct[3];

            _product.AddProduct(_product);

            ProviderMessage.ProductAdded();
        }
    }
}
