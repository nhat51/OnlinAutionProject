using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.Data;
using OnlineAuction.Models;

namespace OnlineAuction.Controllers
{
    public class BidOrdersController : Controller
    {
        private readonly OnlineAuctionContext _context;

        public BidOrdersController(OnlineAuctionContext context)
        {
            _context = context;
        }

        // GET: BidOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.BidOrders.ToListAsync());
        }

        // GET: BidOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bidOrder = await _context.BidOrders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bidOrder == null)
            {
                return NotFound();
            }

            return View(bidOrder);
        }

        // GET: BidOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BidOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Product_ID,Bid_Start_Time,Bid_End_Time,Bid_Chair_Cost,Base_Price,IsActive,Increment_Price_Per_Bid,Cool_Down_Time_Per_Bid")] BidOrder bidOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bidOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bidOrder);
        }

        // GET: BidOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bidOrder = await _context.BidOrders.FindAsync(id);
            if (bidOrder == null)
            {
                return NotFound();
            }
            return View(bidOrder);
        }

        // POST: BidOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Product_ID,Bid_Start_Time,Bid_End_Time,Bid_Chair_Cost,Base_Price,IsActive,Increment_Price_Per_Bid,Cool_Down_Time_Per_Bid")] BidOrder bidOrder)
        {
            if (id != bidOrder.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bidOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BidOrderExists(bidOrder.ID))
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
            return View(bidOrder);
        }

        // GET: BidOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bidOrder = await _context.BidOrders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bidOrder == null)
            {
                return NotFound();
            }

            return View(bidOrder);
        }

        // POST: BidOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bidOrder = await _context.BidOrders.FindAsync(id);
            _context.BidOrders.Remove(bidOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BidOrderExists(int id)
        {
            return _context.BidOrders.Any(e => e.ID == id);
        }
    }
}
