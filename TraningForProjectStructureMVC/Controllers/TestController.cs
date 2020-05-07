using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraningForProjectStructureMVC.Filters;

namespace TraningForProjectStructureMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [MyAuthAttribute]
        public ActionResult CustomAction()
        {
            ViewBag.Message = "Your Test page.";
            return View();
        }
    }
}