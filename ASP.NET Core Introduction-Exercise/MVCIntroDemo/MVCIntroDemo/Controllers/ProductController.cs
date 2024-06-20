﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MVCIntroDemo.Models;
using System.Text;
using System.Text.Json;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IEnumerable<ProductViewModel> products
          =new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id=1,
                Name="Cheese",
                Price=7.00
            },
            new ProductViewModel()
            {
                Id=2,
                Name="Ham",
                Price=5.50
            },
            new ProductViewModel()
            {
                Id=3,
                Name="Bread",
                Price=1.50
            }



        };

        [ActionName("My-Product")]
        public IActionResult Index(string keyword)
        {
            if (keyword != null)
            {
                var product = this.products.Where(
                    p => p.Name.ToLower()
                    .Contains(keyword.ToLower()));
                return View(product);
            }

            return View(products);
        }
        public IActionResult ById(int id)
        {
            var product = this.products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return BadRequest();
            }
            return View(product);

        }
        public IActionResult AllAsJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return Json(products,options);

        }
        public IActionResult AllAsText()
        {
            StringBuilder sb=new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"Product {product.Id}:{product.Name} - " +
                    $"{product.Price} lv.");
            }

            return Content(sb.ToString());

        }
        public IActionResult AllAsTextFile()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"Product {product.Id}:{product.Name} - " +
                    $"{product.Price} lv.");
            }
            Response.Headers.Add(HeaderNames.ContentDisposition
                , @"attachment;filename=products.txt");
            return File(Encoding.UTF8.GetBytes(sb.ToString().Trim()),"text/plain");

        }
    }
}
