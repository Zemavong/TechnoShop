using System.Collections.Generic;

namespace TechnoShop.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string Desc { get; set; }

        public List<Item>  Items { get; set; }

    }
}
