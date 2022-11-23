using System.Collections.Generic;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Mocks
{
    public class MockCategory : IitemsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()
                {
                    new Category { categoryName = "Телефоны", Desc = "Новейшие телефоны на рынке" },
                    new Category { categoryName = "Ноутбуки", Desc = "Мощнейшие ноутбуки на рынке" },
                    new Category { categoryName = "Телевизоры", Desc = "Качественные телевизоры на рынке" }
                };
            }
        }
    }
}
