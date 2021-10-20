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
    public class BiddersController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public BiddersController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bidders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bidder>>> GetBidders()
        {
            return await _context.Bidders.ToListAsync();
        }

        // GET: api/Bidders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bidder>> GetBidder(int id)
        {
            var bidder = await _context.Bidders.FindAsync(id);

            if (bidder == null)
            {
                return NotFound();
            }

            return bidder;
        }

        // PUT: api/Bidders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBidder(int id, Bidder bidder)
        {
            if (id != bidder.ID)
            {
                return BadRequest();
            }

            _context.Entry(bidder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BidderExists(id))
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

        // POST: api/Bidders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bidder>> PostBidder(Bidder bidder)
        {
            _context.Bidders.Add(bidder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBidder", new { id = bidder.ID }, bidder);
        }

        // DELETE: api/Bidders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBidder(int id)
        {
            var bidder = await _context.Bidders.FindAsync(id);
            if (bidder == null)
            {
                return NotFound();
            }

            _context.Bidders.Remove(bidder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BidderExists(int id)
        {
            return _context.Bidders.Any(e => e.ID == id);
        }
    }
}
