using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using TechnoShop.Migrations;

namespace TechnoShop.Data.Models
{
    public class ShopCart
    {

        private readonly AppDBcontent appDBcontent;

        public ShopCart(AppDBcontent appDBContent)
        {
            this.appDBcontent = appDBContent;
        }

        public string ShopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBcontent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Item item)
        {
            appDBcontent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                item = item,
                price = item.price
            });

            appDBcontent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBcontent.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.item).ToList();
        }

    }
}
