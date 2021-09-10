using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace KramDeliveryFoodAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IList<Product> GetProducts()
        {
            var result = _productService.GetAllProducts();

            return result;
        }

        [HttpGet]
        public IList<Product> GetProductsByName(string categoryName)
        {
            var result = _productService.GetProductsByCategoryName(categoryName);

            return result;
        }
        
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.AddProduct(product);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var product = _productService.GetProductById(id);
            _productService.DeleteProduct(product);

            return Ok();
        }
    }
}
