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
    public class Bid_coin_packController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Bid_coin_packController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bid_coin_pack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bid_coin_pack>>> GetBid_Coin_Packs()
        {
            return await _context.Bid_Coin_Packs.ToListAsync();
        }

        // GET: api/Bid_coin_pack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bid_coin_pack>> GetBid_coin_pack(int id)
        {
            var bid_coin_pack = await _context.Bid_Coin_Packs.FindAsync(id);

            if (bid_coin_pack == null)
            {
                return NotFound();
            }

            return bid_coin_pack;
        }

        // PUT: api/Bid_coin_pack/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBid_coin_pack(int id, Bid_coin_pack bid_coin_pack)
        {
            if (id != bid_coin_pack.ID)
            {
                return BadRequest();
            }

            _context.Entry(bid_coin_pack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bid_coin_packExists(id))
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

        // POST: api/Bid_coin_pack
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bid_coin_pack>> PostBid_coin_pack(Bid_coin_pack bid_coin_pack)
        {
            _context.Bid_Coin_Packs.Add(bid_coin_pack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBid_coin_pack", new { id = bid_coin_pack.ID }, bid_coin_pack);
        }

        // DELETE: api/Bid_coin_pack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBid_coin_pack(int id)
        {
            var bid_coin_pack = await _context.Bid_Coin_Packs.FindAsync(id);
            if (bid_coin_pack == null)
            {
                return NotFound();
            }

            _context.Bid_Coin_Packs.Remove(bid_coin_pack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bid_coin_packExists(int id)
        {
            return _context.Bid_Coin_Packs.Any(e => e.ID == id);
        }
    }
}
