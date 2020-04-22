using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            allCars = iAllCars;
            allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Stranica s avtomobilyami";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = allCars.Cars;
            obj.CurrentCategory = "Automobili";
            return View(obj);
        }
    }
}
