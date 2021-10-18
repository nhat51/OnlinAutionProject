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
    public class Product_CategoryController : ControllerBase
    {
        private readonly AuctionOnlineDbContext _context;

        public Product_CategoryController(AuctionOnlineDbContext context)
        {
            _context = context;
        }

        // GET: api/Product_Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_Category>>> GetProduct_Categories()
        {
            return await _context.Product_Categories.ToListAsync();
        }

        // GET: api/Product_Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_Category>> GetProduct_Category(int id)
        {
            var product_Category = await _context.Product_Categories.FindAsync(id);

            if (product_Category == null)
            {
                return NotFound();
            }

            return product_Category;
        }

        // PUT: api/Product_Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Category(int id, Product_Category product_Category)
        {
            if (id != product_Category.ID)
            {
                return BadRequest();
            }

            _context.Entry(product_Category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_CategoryExists(id))
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

        // POST: api/Product_Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_Category>> PostProduct_Category(Product_Category product_Category)
        {
            _context.Product_Categories.Add(product_Category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_Category", new { id = product_Category.ID }, product_Category);
        }

        // DELETE: api/Product_Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_Category(int id)
        {
            var product_Category = await _context.Product_Categories.FindAsync(id);
            if (product_Category == null)
            {
                return NotFound();
            }

            _context.Product_Categories.Remove(product_Category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Product_CategoryExists(int id)
        {
            return _context.Product_Categories.Any(e => e.ID == id);
        }
    }
}
