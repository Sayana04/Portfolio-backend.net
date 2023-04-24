using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeItemsController : ControllerBase
    {
        private readonly AboutMeContext _context;

        public AboutMeItemsController(AboutMeContext context)
        {
            _context = context;
        }

        // GET: api/AboutMeItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AboutMeItem>>> GetPostItems()
        {
          if (_context.PostItems == null)
          {
              return NotFound();
          }
            return await _context.PostItems.ToListAsync();
        }

        // GET: api/AboutMeItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AboutMeItem>> GetAboutMeItem(long id)
        {
          if (_context.PostItems == null)
          {
              return NotFound();
          }
            var aboutMeItem = await _context.PostItems.FindAsync(id);

            if (aboutMeItem == null)
            {
                return NotFound();
            }

            return aboutMeItem;
        }

        // PUT: api/AboutMeItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAboutMeItem(long id, AboutMeItem aboutMeItem)
        {
            if (id != aboutMeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(aboutMeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AboutMeItemExists(id))
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

        // POST: api/AboutMeItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AboutMeItem>> PostAboutMeItem(AboutMeItem aboutMeItem)
        {
          if (_context.PostItems == null)
          {
              return Problem("Entity set 'AboutMeContext.PostItems'  is null.");
          }
            _context.PostItems.Add(aboutMeItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAboutMeItem", new { id = aboutMeItem.Id }, aboutMeItem);
        }

        // DELETE: api/AboutMeItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutMeItem(long id)
        {
            if (_context.PostItems == null)
            {
                return NotFound();
            }
            var aboutMeItem = await _context.PostItems.FindAsync(id);
            if (aboutMeItem == null)
            {
                return NotFound();
            }

            _context.PostItems.Remove(aboutMeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AboutMeItemExists(long id)
        {
            return (_context.PostItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
