using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.Data;
using OnlineAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Views.Component
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly OnlineAuctionContext _db;

        public CategoryViewComponent(OnlineAuctionContext context)
        {
            _db = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(
        int numberCategory)
        {
            var items = await GetItemsAsync(numberCategory);
            return View(items);
        }
        private Task<List<Category>> GetItemsAsync(int numberCategory)
        {
            var categories = _db.Categories.Where(c => c.ID <= numberCategory).Include(s =>s.Sub_Categories).ToListAsync();
           
            return categories;
        }

        
    } 
}
