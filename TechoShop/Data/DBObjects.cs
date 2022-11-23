using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using TechnoShop.Data.Models;

namespace TechnoShop.Data
{
    public class DBObjects
    {

        public static void Initial(AppDBcontent content)
        {



            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Item.Any())
            {
                content.AddRange(
                    new Item { name = "Huawei", desc = "телефончик", img = "", price = 400, isFavorite = true, available = 13, Category = Categories["Телефоны"] }
                    );
            }

            content.SaveChanges();

        }

        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoryName = "Телефоны", Desc = "Новейшие телефоны на рынке" },
                    new Category { categoryName = "Ноутбуки", Desc = "Мощнейшие ноутбуки на рынке" },
                    new Category { categoryName = "Телевизоры", Desc = "Качественные телевизоры на рынке" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);

                }

                return category;
            }
        }
    }
}
