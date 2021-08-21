using KramDeliverFoodCompleted.Data;
using KramDeliverFoodCompleted.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KramDeliveryFoodAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
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
        
    }
}
