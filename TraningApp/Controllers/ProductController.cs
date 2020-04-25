using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraningApp.Models;

namespace TraningApp.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product() 
            {
                ProductId = 1,
                Name = "Шариковая ручка",
                Description = "Синяя шариковая ручка с колпачком",
                Price = 3m,
                Category = "Канцтовары"

            });
            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Бумага А4",
                Description = "Стандартная бумага для цветной и чб печати",
                Price = 15m,
                Category = "Канцтовары"

            });
            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Мобильный телефон",
                Description = "Телефон с камерой",
                Price = 250m,
                Category = "Техника"

            });

            return View(products);
        }

    }
}