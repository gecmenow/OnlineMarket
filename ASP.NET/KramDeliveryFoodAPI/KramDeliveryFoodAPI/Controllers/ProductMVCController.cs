using AutoMapper;
using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using KramDeliveryFoodAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KramDeliveryFoodAPI.Controllers
{
    public class ProductMVCController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProviderService _providerService;

        public ProductMVCController(IProductService productService, ICategoryService categoryService, IProviderService providerService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _providerService = providerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _productService.GetAllProducts();

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductVM product)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductVM, Product>());
                var mapper = new Mapper(config);
                var mappedProduct = mapper.Map<ProductVM, Product>(product);
                _productService.AddProduct(mappedProduct);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var result = _productService.GetProductById(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductVM>());
            var mapper = new Mapper(config);
            var mappedProduct = mapper.Map<Product, ProductVM>(result);

            return View(mappedProduct);
        }

        [HttpPost]
        public IActionResult Edit(ProductVM product)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductVM, Product>());
                var mapper = new Mapper(config);
                var mappedProduct = mapper.Map<ProductVM, Product>(product);
                _productService.UpdateProduct(mappedProduct);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var result = _productService.GetProductById(id);
            _productService.DeleteProduct(result);

            return RedirectToAction("Index");
        }
    }
}