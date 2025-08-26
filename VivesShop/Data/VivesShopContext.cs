using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VivesShop.Models;

namespace VivesShop.Data
{
    public class VivesShopContext : DbContext
    {
        public VivesShopContext(DbContextOptions<VivesShopContext> options) : base(options)
        {
        }

        public DbSet<ShopItem> ShopItems { get; set; }
    }
}

