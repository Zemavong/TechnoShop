using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Repository
{
    public class ItemRepository : IAllItems
    {

        private readonly AppDBcontent appDBcontent;

        public ItemRepository(AppDBcontent appDBContent)
        {
            this.appDBcontent = appDBContent;
        }

        public IEnumerable<Item> Items => appDBcontent.Item.Include(c => c.Category);

        public IEnumerable<Item> getFavItems => appDBcontent.Item.Where(p => p.isFavorite).Include(c => c.Category);

        public Item getObjectItem(int itemId) => appDBcontent.Item.FirstOrDefault(p => p.id == itemId);
    }
}
