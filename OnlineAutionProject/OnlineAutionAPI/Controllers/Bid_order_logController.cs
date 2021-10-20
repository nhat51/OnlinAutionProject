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
    public class Bid_order_logController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Bid_order_logController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Bid_order_log
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bid_order_log>>> GetBid_Order_Logs()
        {
            return await _context.Bid_Order_Logs.ToListAsync();
        }

        // GET: api/Bid_order_log/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bid_order_log>> GetBid_order_log(int id)
        {
            var bid_order_log = await _context.Bid_Order_Logs.FindAsync(id);

            if (bid_order_log == null)
            {
                return NotFound();
            }

            return bid_order_log;
        }

        // PUT: api/Bid_order_log/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBid_order_log(int id, Bid_order_log bid_order_log)
        {
            if (id != bid_order_log.ID)
            {
                return BadRequest();
            }

            _context.Entry(bid_order_log).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bid_order_logExists(id))
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

        // POST: api/Bid_order_log
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bid_order_log>> PostBid_order_log(Bid_order_log bid_order_log)
        {
            _context.Bid_Order_Logs.Add(bid_order_log);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBid_order_log", new { id = bid_order_log.ID }, bid_order_log);
        }

        // DELETE: api/Bid_order_log/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBid_order_log(int id)
        {
            var bid_order_log = await _context.Bid_Order_Logs.FindAsync(id);
            if (bid_order_log == null)
            {
                return NotFound();
            }

            _context.Bid_Order_Logs.Remove(bid_order_log);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bid_order_logExists(int id)
        {
            return _context.Bid_Order_Logs.Any(e => e.ID == id);
        }
    }
}
