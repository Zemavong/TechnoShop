using System.Collections.Generic;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Interfaces
{
    public interface IitemsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
