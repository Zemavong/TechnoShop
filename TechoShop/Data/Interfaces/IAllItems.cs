using System.Collections.Generic;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Interfaces
{
    public interface IAllItems
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> getFavItems { get; }
        Item getObjectItem(int itemId);
    }
}
