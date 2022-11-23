using System.Collections.Generic;
using TechnoShop.Data.Models;

namespace TechnoShop.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> allItems { get; set; }

        public string currCategory { get; set; }
    }
}
