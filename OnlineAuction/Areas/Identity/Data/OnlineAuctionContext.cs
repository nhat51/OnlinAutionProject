﻿using System;
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
        public DbSet<ProductImage> ProdcutImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BidderBidRegist> BidderBidRegists { get; set; }
        public DbSet<BidOrder> BidOrders { get; set; }
        public DbSet<BidOrderLog> BidOrderLogs { get; set; }
        public DbSet<BidCoinPack> BidCoinPacks { get; set; }
        public DbSet<BidCoinTransLog> BidCoinTransLogs { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
