using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderInteraction
    {
        private readonly IProductService _productService;

        public ProviderInteraction(IProductService productService)
        {
            _productService = productService;
        }

        public void AddProduct()
        {
            ProviderMessanger.ShowAddingProductMessage();
            var product = new Product();
            product.Id = Guid.NewGuid();
            Console.Write("Type product name: ");
            product.Name = Console.ReadLine();
            Console.Write("Type product price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Type product specification: ");
            product.Specifications = Console.ReadLine();
            Console.Write("Type product description: ");
            product.Description = Console.ReadLine();
            _productService.AddProduct(product);
            ProviderMessanger.ShowSuccessAddingMessage();
        }
    }
}
