using System;
using OnlineAuction.Areas.Identity.Data;
using OnlineAuction.Data;
using OnlineAuction.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;



namespace OnlineAuction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<OnlineAuctionContext>();
                    var userManager = services.GetRequiredService<UserManager<OnlineAuctionUser>>();
                    DbInittializer.InitializeAsync(context, services, userManager).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured while seeding database");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}
