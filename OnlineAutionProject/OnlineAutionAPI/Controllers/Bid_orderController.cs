using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineAutionAPI.Data;
using OnlineAutionAPI.Entities;

namespace OnlineAutionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bid_orderController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Bid_orderController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bid_order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bid_order>>> GetBid_Orders()
        {
            return await _context.Bid_Orders.ToListAsync();
        }

        // GET: api/Bid_order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bid_order>> GetBid_order(int id)
        {
            var bid_order = await _context.Bid_Orders.FindAsync(id);

            if (bid_order == null)
            {
                return NotFound();
            }

            return bid_order;
        }

        // PUT: api/Bid_order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBid_order(int id, Bid_order bid_order)
        {
            if (id != bid_order.ID)
            {
                return BadRequest();
            }

            _context.Entry(bid_order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bid_orderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bid_order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bid_order>> PostBid_order(Bid_order bid_order)
        {
            _context.Bid_Orders.Add(bid_order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBid_order", new { id = bid_order.ID }, bid_order);
        }

        // DELETE: api/Bid_order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBid_order(int id)
        {
            var bid_order = await _context.Bid_Orders.FindAsync(id);
            if (bid_order == null)
            {
                return NotFound();
            }

            _context.Bid_Orders.Remove(bid_order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bid_orderExists(int id)
        {
            return _context.Bid_Orders.Any(e => e.ID == id);
        }
    }
}
