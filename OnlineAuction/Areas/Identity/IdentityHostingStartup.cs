using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineAuction.Areas.Identity.Data;
using OnlineAuction.Data;

[assembly: HostingStartup(typeof(OnlineAuction.Areas.Identity.IdentityHostingStartup))]
namespace OnlineAuction.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineAuctionContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OnlineAuctionContextConnection")));

                //services.AddDefaultIdentity<OnlineAuctionUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<OnlineAuctionContext>();
            });
        }
    }
}