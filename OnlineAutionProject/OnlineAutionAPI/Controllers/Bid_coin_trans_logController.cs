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
    public class Bid_coin_trans_logController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Bid_coin_trans_logController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bid_coin_trans_log
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bid_coin_trans_log>>> GetBid_Coin_Trans_Logs()
        {
            return await _context.Bid_Coin_Trans_Logs.ToListAsync();
        }

        // GET: api/Bid_coin_trans_log/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bid_coin_trans_log>> GetBid_coin_trans_log(int id)
        {
            var bid_coin_trans_log = await _context.Bid_Coin_Trans_Logs.FindAsync(id);

            if (bid_coin_trans_log == null)
            {
                return NotFound();
            }

            return bid_coin_trans_log;
        }

        // PUT: api/Bid_coin_trans_log/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBid_coin_trans_log(int id, Bid_coin_trans_log bid_coin_trans_log)
        {
            if (id != bid_coin_trans_log.ID)
            {
                return BadRequest();
            }

            _context.Entry(bid_coin_trans_log).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bid_coin_trans_logExists(id))
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

        // POST: api/Bid_coin_trans_log
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bid_coin_trans_log>> PostBid_coin_trans_log(Bid_coin_trans_log bid_coin_trans_log)
        {
            _context.Bid_Coin_Trans_Logs.Add(bid_coin_trans_log);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBid_coin_trans_log", new { id = bid_coin_trans_log.ID }, bid_coin_trans_log);
        }

        // DELETE: api/Bid_coin_trans_log/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBid_coin_trans_log(int id)
        {
            var bid_coin_trans_log = await _context.Bid_Coin_Trans_Logs.FindAsync(id);
            if (bid_coin_trans_log == null)
            {
                return NotFound();
            }

            _context.Bid_Coin_Trans_Logs.Remove(bid_coin_trans_log);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bid_coin_trans_logExists(int id)
        {
            return _context.Bid_Coin_Trans_Logs.Any(e => e.ID == id);
        }
    }
}
