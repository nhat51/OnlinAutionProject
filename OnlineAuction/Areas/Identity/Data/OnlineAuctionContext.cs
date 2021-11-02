using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.Areas.Identity.Data;
using OnlineAuction.Models;

namespace OnlineAuction.Data
{
    public class OnlineAuctionContext : IdentityDbContext<OnlineAuctionUser>
    {
        public OnlineAuctionContext(DbContextOptions<OnlineAuctionContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> Prodcut_Images { get; set; }
        public DbSet<Category> Product_Categories { get; set; }
        public DbSet<BidderBidRegist> Bidder_Bid_Regists { get; set; }
        public DbSet<BidOrder> Bid_Orders { get; set; }
        public DbSet<BidOrderLog> Bid_Order_Logs { get; set; }
        public DbSet<BidCoinPack> Bid_Coin_Packs { get; set; }
        public DbSet<BidCoinTransLog> Bid_Coin_Trans_Logs { get; set; }
        public DbSet<SubCategory> Sub_category { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
