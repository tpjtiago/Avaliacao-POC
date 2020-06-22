using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Avaliacao.Model;

namespace Avaliacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RickMoriesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public RickMoriesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/RickMories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RickMory>>> GetRickMory()
        {
            return await _context.RickMory.ToListAsync();
        }

        // GET: api/RickMories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RickMory>> GetRickMory(Guid id)
        {
            var rickMory = await _context.RickMory.FindAsync(id);

            if (rickMory == null)
            {
                return NotFound();
            }

            return rickMory;
        }

        // PUT: api/RickMories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRickMory(Guid id, RickMory rickMory)
        {
            if (id != rickMory.id)
            {
                return BadRequest();
            }

            _context.Entry(rickMory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RickMoryExists(id))
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

        // POST: api/RickMories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RickMory>> PostRickMory(RickMory rickMory)
        {
            _context.RickMory.Add(rickMory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRickMory", new { id = rickMory.id }, rickMory);
        }

        // DELETE: api/RickMories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RickMory>> DeleteRickMory(Guid id)
        {
            var rickMory = await _context.RickMory.FindAsync(id);
            if (rickMory == null)
            {
                return NotFound();
            }

            _context.RickMory.Remove(rickMory);
            await _context.SaveChangesAsync();

            return rickMory;
        }

        private bool RickMoryExists(Guid id)
        {
            return _context.RickMory.Any(e => e.id == id);
        }
    }
}
