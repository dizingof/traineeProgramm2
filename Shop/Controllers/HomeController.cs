using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars CarRep;
    
        public HomeController(IAllCars carRep)
        {
            CarRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = CarRep.GetFavouriteCars
            };
            return View(homeCars);
        }
    }
}
