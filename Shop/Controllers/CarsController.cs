using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
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
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string Category = category;
            IEnumerable<Car> cars = null;
            string currentCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = allCars.Cars.OrderBy(i => i.Id);

            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.Category.CategoryName.Equals("ElektroCars")).OrderBy(i => i.Id);
                    currentCategory = "ElektroCars";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.Category.CategoryName.Equals("Classik cars")).OrderBy(i => i.Id);
                    currentCategory = "Classik cars";
                }
               
                            
            }
            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrentCategory = currentCategory
            };

            ViewBag.Title = "Stranica s avtomobilyami";
            
            return View(carObj);
        }
    }
}
