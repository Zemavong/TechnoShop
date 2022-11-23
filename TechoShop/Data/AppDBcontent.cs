using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using TechnoShop.Data.Mocks;
using TechnoShop.Data.Models;

namespace TechnoShop.Data
{
    public class AppDBcontent : DbContext
    {

        public AppDBcontent(DbContextOptions<AppDBcontent> options) : base(options)
        {



        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public  DbSet<OrderDetail> OrderDetail { get; set; }

    }
}
