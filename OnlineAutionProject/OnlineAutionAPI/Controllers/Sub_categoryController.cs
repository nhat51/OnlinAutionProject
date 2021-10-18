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
    public class Sub_categoryController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Sub_categoryController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Sub_category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sub_category>>> GetSub_category()
        {
            return await _context.Sub_category.ToListAsync();
        }

        // GET: api/Sub_category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sub_category>> GetSub_category(int id)
        {
            var sub_category = await _context.Sub_category.FindAsync(id);

            if (sub_category == null)
            {
                return NotFound();
            }

            return sub_category;
        }

        // PUT: api/Sub_category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSub_category(int id, Sub_category sub_category)
        {
            if (id != sub_category.ID)
            {
                return BadRequest();
            }

            _context.Entry(sub_category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sub_categoryExists(id))
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

        // POST: api/Sub_category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sub_category>> PostSub_category(Sub_category sub_category)
        {
            _context.Sub_category.Add(sub_category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSub_category", new { id = sub_category.ID }, sub_category);
        }

        // DELETE: api/Sub_category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSub_category(int id)
        {
            var sub_category = await _context.Sub_category.FindAsync(id);
            if (sub_category == null)
            {
                return NotFound();
            }

            _context.Sub_category.Remove(sub_category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Sub_categoryExists(int id)
        {
            return _context.Sub_category.Any(e => e.ID == id);
        }
    }
}
