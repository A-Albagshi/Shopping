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
            new ProductModel(1,"Food",121.3f,"https://www.besthealthmag.ca/wp-content/uploads/2019/07/junk-food-1.gif"),
            new ProductModel(2,"Off",134.3f,"https://off.com.ph/-/media/images/off/ph/products-en/products-landing/landing/off_overtime_product_collections_large_2x.jpg?la=en-ph"),
            new ProductModel(3,"Dis",10.3f,"https://i.insider.com/601029561d2df20018b70d54?width=700")
        };
        // GET 
        public IActionResult Index(string color)
        {
            ViewData["Color"] = color;
            ViewData["Products"] = products;
            return View();
        }
        public IActionResult Details(int id)
        {
                ProductModel p = products.Find(product => product.Id == id);
                ViewData["Product"] = p;
                /*
                ProductModel p = new ProductModel(2, "lis", 23.2f,"https://i.insider.com/601029561d2df20018b70d54?width=700");
                ViewData["Product"] = p;
                */
                return View();
        }
        public IActionResult Random()
        {
            return View();
        }
    }
}