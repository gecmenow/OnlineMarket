using KramDelivery.Structure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KramDeliveryFoodAPI.Controllers
{
    public class ProductControllerMVC : Controller
    {
        public readonly IProductService _productService;

        public ProductControllerMVC(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var result = _productService.GetAllProducts();

            return View(result);
        }
    }
}
