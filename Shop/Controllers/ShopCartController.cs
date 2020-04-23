using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private  IAllCars CarRep;
        private readonly ShopCart ShopCart;
        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            CarRep = carRep;
            ShopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = ShopCart.GetShopItems();
            ShopCart.ListShopItems = items;
            var obj = new ShopCartViewModel { shopCart = ShopCart };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = CarRep.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                ShopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
