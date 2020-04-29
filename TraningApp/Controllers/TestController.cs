using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraningApp.Models;

namespace TraningApp.Controllers
{
    public class TestController : Controller
    {
        Product product = new Product(1, "table", "big table", 20000, "stoli" );
        // GET: Test
       
        public ActionResult Index()
        {
            return View(product);
        }
    }
}