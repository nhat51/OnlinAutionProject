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
    public class Prodcut_ImageController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Prodcut_ImageController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Prodcut_Image
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prodcut_Image>>> GetProdcut_Images()
        {
            return await _context.Prodcut_Images.ToListAsync();
        }

        // GET: api/Prodcut_Image/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prodcut_Image>> GetProdcut_Image(int id)
        {
            var prodcut_Image = await _context.Prodcut_Images.FindAsync(id);

            if (prodcut_Image == null)
            {
                return NotFound();
            }

            return prodcut_Image;
        }

        // PUT: api/Prodcut_Image/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdcut_Image(int id, Prodcut_Image prodcut_Image)
        {
            if (id != prodcut_Image.ID)
            {
                return BadRequest();
            }

            _context.Entry(prodcut_Image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Prodcut_ImageExists(id))
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

        // POST: api/Prodcut_Image
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prodcut_Image>> PostProdcut_Image(Prodcut_Image prodcut_Image)
        {
            _context.Prodcut_Images.Add(prodcut_Image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdcut_Image", new { id = prodcut_Image.ID }, prodcut_Image);
        }

        // DELETE: api/Prodcut_Image/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdcut_Image(int id)
        {
            var prodcut_Image = await _context.Prodcut_Images.FindAsync(id);
            if (prodcut_Image == null)
            {
                return NotFound();
            }

            _context.Prodcut_Images.Remove(prodcut_Image);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Prodcut_ImageExists(int id)
        {
            return _context.Prodcut_Images.Any(e => e.ID == id);
        }
    }
}
