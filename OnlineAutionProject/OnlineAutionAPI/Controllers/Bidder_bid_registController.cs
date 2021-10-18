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
    public class Bidder_bid_registController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Bidder_bid_registController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bidder_bid_regist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bidder_bid_regist>>> GetBidder_Bid_Regists()
        {
            return await _context.Bidder_Bid_Regists.ToListAsync();
        }

        // GET: api/Bidder_bid_regist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bidder_bid_regist>> GetBidder_bid_regist(int id)
        {
            var bidder_bid_regist = await _context.Bidder_Bid_Regists.FindAsync(id);

            if (bidder_bid_regist == null)
            {
                return NotFound();
            }

            return bidder_bid_regist;
        }

        // PUT: api/Bidder_bid_regist/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBidder_bid_regist(int id, Bidder_bid_regist bidder_bid_regist)
        {
            if (id != bidder_bid_regist.ID)
            {
                return BadRequest();
            }

            _context.Entry(bidder_bid_regist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bidder_bid_registExists(id))
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

        // POST: api/Bidder_bid_regist
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bidder_bid_regist>> PostBidder_bid_regist(Bidder_bid_regist bidder_bid_regist)
        {
            _context.Bidder_Bid_Regists.Add(bidder_bid_regist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBidder_bid_regist", new { id = bidder_bid_regist.ID }, bidder_bid_regist);
        }

        // DELETE: api/Bidder_bid_regist/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBidder_bid_regist(int id)
        {
            var bidder_bid_regist = await _context.Bidder_Bid_Regists.FindAsync(id);
            if (bidder_bid_regist == null)
            {
                return NotFound();
            }

            _context.Bidder_Bid_Regists.Remove(bidder_bid_regist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bidder_bid_registExists(int id)
        {
            return _context.Bidder_Bid_Regists.Any(e => e.ID == id);
        }
    }
}
