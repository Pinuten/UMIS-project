using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatladaController : ControllerBase
    {
        private readonly MatladaContext _context;

        public MatladaController(MatladaContext context)
        {
            _context = context;
        }

        // GET: api/Matlada
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matlada>>> GetMatlada()
        {
            return await _context.Matlador.ToListAsync();
        }

        // GET: api/Matlada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Matlada>> GetMatlada(int id)
        {
            var matlada = await _context.Matlador.FindAsync(id);

            if (matlada == null)
            {
                return NotFound();
            }

            return matlada;
        }

        // PUT: api/Matlada/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatlada(int id, Matlada matlada)
        {
            if (id != matlada.Id)
            {
                return BadRequest();
            }

            _context.Entry(matlada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatladaExists(id))
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

        // POST: api/Matlada
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> AddMatlada([FromBody] inputModel inputModel)
        {

            Console.WriteLine("we are here", inputModel);
            
            var matlada = new Matlada
            {
                Name = inputModel.Name,
                Size = inputModel.Size,
                CreatedAt = DateTime.UtcNow 
            };

            _context.Matlador.Add(matlada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatlada", new { id = matlada.Id }, matlada);

        }
        // DELETE: api/Matlada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatlada(int id)
        {
            var matlada = await _context.Matlador.FindAsync(id);
            if (matlada == null)
            {
                return NotFound();
            }

            _context.Matlador.Remove(matlada);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost("Eaten/{id}")]
        public async Task<IActionResult> EatMatlada(int id)
        {
            var matlada = await _context.Matlador.FindAsync(id);
            if (matlada == null)
            {
                return NotFound();
            }

            var stats = await _context.Statistics.FirstOrDefaultAsync();
            if (stats == null)
            {
                stats = new Statistics { Eaten = 0 };
                _context.Statistics.Add(stats);
            }

            stats.Eaten += 1;
            _context.Matlador.Remove(matlada);

            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("Eaten")]
        public async Task<int> GetEaten()
        {
            var stats = await _context.Statistics.FirstOrDefaultAsync();
            if (stats != null)
            {
                return stats.Eaten;
            }
            else
            {

                return 0;
            }
        }


        private bool MatladaExists(int id)
        {
            return _context.Matlador.Any(e => e.Id == id);
        }
    }
}
