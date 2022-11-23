using System;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Mocks;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBcontent appDBcontent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBcontent appDBcontent, ShopCart shopCart)
        {
            this.appDBcontent = appDBcontent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBcontent.Order.Add(order);

            appDBcontent.SaveChanges();
            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ItemID = el.item.id,
                    orderID = order.id,
                    price = el.item.price,
                };
                appDBcontent.OrderDetail.Add(orderDetail);
            }
            appDBcontent.SaveChanges(); 
        }
    }
}
