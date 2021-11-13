using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineAuction.Data;
using OnlineAuction.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OnlineAuctionContext _context;

        public HomeController(ILogger<HomeController> logger,OnlineAuctionContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Category"] = new SelectList(_context.Categories, "ID", "Category_Name");
            
            
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<Category> GetCategories()
        {
            List<Category> category = _context.Categories.ToList();
            
            foreach (var item in category)
            {
                item.Sub_Categories = GetCategories(item.ID).ToList();
            }
            return category;
        }
        public List<SubCategory> GetCategories(int ID)
        {
            List<SubCategory> subccategory = _context.SubCategories.Where(s => s.ID.Equals(ID)).ToList();

            return subccategory;
        }
    }
}
