using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.ListShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.Id,
                    OrderId = order.Id,
                    Price = el.car.Price
                };
                appDBContent.OrderDetail.Add(orderDetail);

            }
            appDBContent.SaveChanges();
        }
    }
}
