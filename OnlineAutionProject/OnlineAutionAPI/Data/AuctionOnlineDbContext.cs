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
        public DbSet<Bidder_bid_regist> Bidder_Bid_Regists { get; set; }
        public DbSet<Bid_order> Bid_Orders { get; set; }
        public DbSet<Bid_order_log> Bid_Order_Logs { get; set; }
        public DbSet<Bid_coin_pack> Bid_Coin_Packs { get; set; }
        public DbSet<Bid_coin_trans_log> Bid_Coin_Trans_Logs { get; set; }
        public DbSet<OnlineAutionAPI.Entities.Sub_category> Sub_category { get; set; }
    }

}
