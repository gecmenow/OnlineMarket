using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace KramDeliveryFoodAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IList<Product> Get()
        {
            var result = _productService.GetAllProducts();

            return result;
        }

        [HttpGet("{categoryName}")]
        public IList<Product> Get(string categoryName)
        {
            var result = _productService.GetProductsByCategoryName(categoryName);

            return result;
        }
        
        [HttpPost]
        public void Add(Product product)
        {
            _productService.AddProduct(product);
        }

        [HttpPut]
        public void Update(Product product)
        {
            _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var product = _productService.GetProductById(id);
            _productService.DeleteProduct(product);
        }
    }
}
