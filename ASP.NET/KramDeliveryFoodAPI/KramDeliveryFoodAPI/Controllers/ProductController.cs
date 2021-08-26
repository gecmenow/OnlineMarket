﻿using KramDeliverFoodCompleted.Data;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Services;
using Microsoft.AspNetCore.Mvc;
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
        public IList<KramDelivery.Structure.Models.Product> Get()
        {
            var result = _productService.GetProductsForApi();

            return result;
        }
        
        [HttpPost]
        public void Add(KramDelivery.Structure.Models.Product product)
        {
            _productService.AddProduct(product);
        }

        [HttpPut]
        public void Update(KramDelivery.Structure.Models.Product product)
        {
            _productService.UpdateProduct(product);
        }

        [HttpDelete]
        public void Delete(KramDelivery.Structure.Models.Product product)
        {
            _productService.DeleteProduct(product);
        }
        //---Product---
        //(Get product by id)
        //GET Product/id
        //(Get product by category name)
        //GET Product/categoryName
        //---Provider---
        //(Add provider)
        //POST Provider
        //(Get provider information by id)
        //GET Provider/id
        //---UserOrder---
        //(Get user order by id)
        //GET UserOrder/id
        //(Get user orders)
        //GET UserOrder
        //---Category---
        //(Get categories)
        //GET Category
        //(Get category by id)
        //GET Category/id
    }
}
