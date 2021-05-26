using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel(1,"Food",121.3f),
            new ProductModel(2,"Games",134.3f),
            new ProductModel(3,"Dis",10.3f)
        };
        // GET 
        public IActionResult Index()
        {
            ViewData["Products"] = products;
            return View();
        }
        public IActionResult Details(int id=-1)
        {
            Console.WriteLine(products.Count);
            if (id !=-1)
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product.Id);
                    if (product.Id == id)
                    {
                        ViewData["Product"] = product;
                    }
                }
            }
            else
            {
                ProductModel p = new ProductModel(2, "lis", 23.2f);
                ViewData["Product"] = p;
            }
            return View();
        }
        public IActionResult Random()
        {
            return View();
        }
    }
}