using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.Data;
using OnlineAuction.Models;
using OnlineAuction.ViewModels;

namespace OnlineAuction.Controllers
{
    public class AuctionsController : Controller
    {
        private readonly OnlineAuctionContext _context;
        private IWebHostEnvironment webHostEnvironment;

        public AuctionsController(OnlineAuctionContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        // GET: Auctions
        public async Task<IActionResult> Index()
        {
            var onlineAuctionContext = _context.Auctions.Include(a => a.Sub_Category);
            return View(await onlineAuctionContext.ToListAsync());
        }

        // GET: Auctions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions
                .Include(a => a.Sub_Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // GET: Auctions/Create
        public IActionResult Create()
        {
            ViewData["SubCategoryID"] = new SelectList(_context.SubCategories, "ID", "ID");
            return View();
        }

        // POST: Auctions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAuctionViewModel viewModel,ProductImage productImage)
        {
            if (ModelState.IsValid)
            {
                var newAuction = new Auction()
                {
                    ProductName = viewModel.Product_Name,
                    StartPrice = viewModel.StartPrice,
                    EndDate = viewModel.EndDate,
                    Description = viewModel.ProductDescription,
                    

                };
                foreach (var item in viewModel.Product_Image)
                {
                    productImage.Image = UploadImage(item);

                }
                viewModel.Categories = _context.Categories.Include(s => s.Sub_Categories).ToList();
                _context.Add(newAuction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            /*ViewData["SubCategoryID"] = new SelectList(_context.SubCategories, "ID", "ID", auction.SubCategoryID);*/
            return View(viewModel);
        }
        private string UploadImage(IFormFile item)
        {
            string fileName = null;
            if (item != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "image/Product");
                fileName = Guid.NewGuid().ToString() + "-" + item.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    item.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        // GET: Auctions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions.FindAsync(id);
            if (auction == null)
            {
                return NotFound();
            }
            ViewData["SubCategoryID"] = new SelectList(_context.SubCategories, "ID", "ID", auction.SubCategoryID);
            return View(auction);
        }

        // POST: Auctions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,SubCategoryID,EndDate,StartPrice,Status")] Auction auction)
        {
            if (id != auction.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuctionExists(auction.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubCategoryID"] = new SelectList(_context.SubCategories, "ID", "ID", auction.SubCategoryID);
            return View(auction);
        }

        // GET: Auctions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions
                .Include(a => a.Sub_Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // POST: Auctions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auction = await _context.Auctions.FindAsync(id);
            _context.Auctions.Remove(auction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuctionExists(int id)
        {
            return _context.Auctions.Any(e => e.ID == id);
        }
    }
}
