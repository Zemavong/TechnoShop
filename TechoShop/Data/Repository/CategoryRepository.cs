using System.Collections.Generic;
using TechnoShop.Data.Interfaces;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Repository
{
    public class CategoryRepository : IitemsCategory
    {

        private readonly AppDBcontent appDBcontent;

        public CategoryRepository(AppDBcontent appDBContent)
        {
            this.appDBcontent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBcontent.Category; 
    }
}
