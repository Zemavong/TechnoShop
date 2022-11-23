using System.Collections.Generic;
using TechnoShop.Data.Models;

namespace TechnoShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> favItems { get; set; }
    }
}
