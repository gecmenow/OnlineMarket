using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using KramDeliveryFoodAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace KramDeliveryFoodAPI.Controllers
{
    [ServiceFilter(typeof(HandleExceptionFilter))]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMemoryCache _memoryCache;

        public ProductController(IProductService productService, IMemoryCache memoryCache)
        {
            _productService = productService;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        [ServiceFilter(typeof(RequestBodyFilter))]
        public IList<Product> GetProducts()
        {
            if (!_memoryCache.TryGetValue(DateTime.Now.Day, out IList<Product> result))
            {
                result = _productService.GetAllProducts();

                _memoryCache.Set(DateTime.Now.Day, result, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(2)
                });
            }

            return result;
        }

        [HttpGet]
        [ServiceFilter(typeof(HandleExceptionFilter))]
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
