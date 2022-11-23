using Microsoft.AspNetCore.Mvc;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Mocks;
using TechnoShop.Data.Models;

namespace TechnoShop.Controllers
{
    public class OrderController : Controller
    {

        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders appDBcontent, ShopCart shopCart)
        {
            this.allOrders = appDBcontent;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ обработан";
            return View();
        }
    }
}
