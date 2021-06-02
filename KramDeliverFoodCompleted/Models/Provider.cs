using KramDeliverFoodCompleted.Interaction;
using System;

namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        private readonly ProviderReader _providerReader;
        private readonly Data.Product _productModel;
        private readonly Product _product;

        public Provider(Data.Product productModel, Product product, ProviderReader providerReader)
        {
            _providerReader = providerReader;
            _productModel = productModel;
            _product = product;
        }

        public void AddProduct()
        {
            var newProduct = _providerReader.InputProductFields();

            _productModel.Id = new Guid();
            _productModel.Name = newProduct[0];
            _productModel.Price = Convert.ToDecimal(newProduct[1]);
            _productModel.Specifications = newProduct[2];
            _productModel.Description = newProduct[3];

            _product.AddProduct(_productModel);

            ProviderMessager.ProductAdded();
        }
    }
}
