using Microsoft.AspNetCore.Mvc;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;
using TechnoShop.ViewModels;

namespace TechnoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllItems _itemRep;


        public HomeController(IAllItems itemRep)
        {
            _itemRep = itemRep;
        }

        public ViewResult Index()
        {
            var homeItems = new HomeViewModel
            {
                favItems = _itemRep.getFavItems
            };

            return View(homeItems);
        }
    }
}
