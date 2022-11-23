using System.Collections.Generic;
using System.Linq;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Mocks
{
    public class MockItems : IAllItems
    {

        private readonly IitemsCategory _categoryItems = new MockCategory();

        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>()
                {
                    new Item { name = "Huawei", desc = "телефончик", img = "", price = 400, isFavorite = true, available = 13, Category = _categoryItems.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Item> getFavItems { get; set; }

        public Item getObjectItem(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
