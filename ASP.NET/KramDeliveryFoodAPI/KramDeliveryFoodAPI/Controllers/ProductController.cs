using KramDeliverFoodCompleted.Data;
using KramDeliverFoodCompleted.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KramDeliveryFoodAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IList<KramDeliverFoodCompleted.Models.Product> Get()
        {
            var productService = new ProductService(new StoreContext(), new LoggerService(), new SerializerService());
            var result = productService.GetProductsForApi();

            return result;
        }
        
        [HttpPost]
        public void Add(KramDeliverFoodCompleted.Models.Product product)
        {
            var productService = new ProductService(new StoreContext(), new LoggerService(), new SerializerService());
            productService.AddProduct(product);
        }

        [HttpPut]
        public void Update(KramDeliverFoodCompleted.Models.Product product)
        {
            var productService = new ProductService(new StoreContext(), new LoggerService(), new SerializerService());
            productService.UpdateProduct(product);
        }

        [HttpDelete]
        public void Delete(KramDeliverFoodCompleted.Models.Product product)
        {
            var productService = new ProductService(new StoreContext(), new LoggerService(), new SerializerService());
            productService.DeleteProduct(product);
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
