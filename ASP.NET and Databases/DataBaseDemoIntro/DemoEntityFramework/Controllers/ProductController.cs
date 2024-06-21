﻿using DemoEntityFramework.Contracts;
using DemoEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoEntityFramework.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices productService;
        public ProductController(IProductServices _productServices)
        {
            productService = _productServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new ProductViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductViewModel model)
        {
            if(ModelState.IsValid==false)
            {
                return View(model);
            }
           await productService.AddProductAsync(model);
           return RedirectToAction(nameof(Index)); 
        }
        public async Task<IActionResult> Edit(int id)
        {
           var model= await productService.GetByIdAsync(id);
           return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductViewModel model,int id)
        {
            if(ModelState.IsValid==false || model.Id!=id)
            {
                return View(model);
            }
            await productService.UpdateProductAsync(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id)
        {
           await productService.DeleteProductAsync(id);
           return RedirectToAction(nameof(Index));

        }

    }
}
