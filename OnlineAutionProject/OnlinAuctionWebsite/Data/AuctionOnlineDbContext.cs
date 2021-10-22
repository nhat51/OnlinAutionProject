using Microsoft.EntityFrameworkCore;
using OnlinAuctionWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Data
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
        public DbSet<Product_Image> Product_Images { get; set; }
        public DbSet<Product_Category> Product_Categories { get; set; }
        public DbSet<Bidder> Bidders { get; set; }
        public DbSet<Bidder_Bid_Regist> Bidder_Bid_Regists { get; set; }
        public DbSet<Bid_Order> Bid_Orders { get; set; }
        public DbSet<Bid_Order_Log> Bid_Order_Logs { get; set; }
        public DbSet<Bid_Coin_Pack> Bid_Coin_Packs { get; set; }
        public DbSet<Bid_Coin_Trans_Log> Bid_Coin_Trans_Logs { get; set; }
        public DbSet<Sub_Category> Sub_category { get; set; }
    }

}
