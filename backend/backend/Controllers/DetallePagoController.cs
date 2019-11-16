using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Model.DAL;
using backend.Model.Entities;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallePagoController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public DetallePagoController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/DetallePago
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallePago>>> GetDetallePago()
        {
            return await _context.DetallePago.ToListAsync();
        }

        // GET: api/DetallePago/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetallePago>> GetDetallePago(int id)
        {
            var detallePago = await _context.DetallePago.FindAsync(id);

            if (detallePago == null)
            {
                return NotFound();
            }

            return detallePago;
        }

        // PUT: api/DetallePago/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetallePago(int id, DetallePago detallePago)
        {
            if (id != detallePago.IdTarjeta)
            {
                return BadRequest();
            }

            _context.Entry(detallePago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetallePagoExists(id))
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

        // POST: api/DetallePago
        [HttpPost]
        public async Task<ActionResult<DetallePago>> PostDetallePago(DetallePago detallePago)
        {
            _context.DetallePago.Add(detallePago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetallePago", new { id = detallePago.IdTarjeta }, detallePago);
        }

        // DELETE: api/DetallePago/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DetallePago>> DeleteDetallePago(int id)
        {
            var detallePago = await _context.DetallePago.FindAsync(id);
            if (detallePago == null)
            {
                return NotFound();
            }

            _context.DetallePago.Remove(detallePago);
            await _context.SaveChangesAsync();

            return detallePago;
        }

        private bool DetallePagoExists(int id)
        {
            return _context.DetallePago.Any(e => e.IdTarjeta == id);
        }
    }
}
