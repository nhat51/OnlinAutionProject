using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OnlineAuction.Areas.Identity.Data;
using OnlineAuction.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public static class DbInittializer
    {
        public static async Task InitializeAsync(Data.OnlineAuctionContext context, IServiceProvider serviceProvider,
            UserManager<OnlineAuctionUser> userManager)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] RoleNames = { "Admin", "User" };
            IdentityResult roleResult;
            foreach (var roleName in RoleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            string Email = "admin@onlineauction.com";
            string password = "Oa123988@";
            if (userManager.FindByEmailAsync(Email).Result == null)
            {
                OnlineAuctionUser user = new OnlineAuctionUser();
                user.UserName = Email;
                user.Email = Email;
                IdentityResult result = userManager.CreateAsync(user, password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
