using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;
using TechnoShop.ViewModels;

namespace TechnoShop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IAllItems _allItems;
        private readonly IitemsCategory _allCategories;

        public ItemsController(IAllItems iAllItems, IitemsCategory iItemsCategory)
        {
            _allItems = iAllItems;
            _allCategories = iItemsCategory;
        }

        [Route("Items/List")]
        [Route("Items/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Item> items = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                items = _allItems.Items.OrderBy(i => i.id);
            } else
            {
                if(string.Equals("phone", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Телефоны")).OrderBy(i => i.id);
                    currCategory = "Телефоны";
                } else if (string.Equals("notbook", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Ноутбуки")).OrderBy(i => i.id);
                    currCategory = "Ноутбуки";
                } else if (string.Equals("tv", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Телевизоры")).OrderBy(i => i.id);
                    currCategory = "Телевизоры";
                }


            }

            var itemObj = new ItemsListViewModel
            {
                allItems = items,
                currCategory = currCategory,
            };

            ViewBag.Title = "Страница с техникой";
            return View(itemObj);
        }

    }
}
