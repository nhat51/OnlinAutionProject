using Microsoft.EntityFrameworkCore;
using OnlineAutionAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Data
{
    public class AuctionOnlineDbContext : DbContext
    {
        public AuctionOnlineDbContext()
        {

        }
        public AuctionOnlineDbContext(DbContextOptions<AuctionOnlineDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Prodcut_Image> Prodcut_Images { get; set; }
        public DbSet<Product_Category> Product_Categories { get; set; }
        public DbSet<Bidder>  Bidders { get; set; }
    }
}
