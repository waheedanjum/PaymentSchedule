using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentSchedule.Models;

namespace PaymentSchedule.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehicelsController : ControllerBase
    {
        private readonly WorkoutContext _context;

        public VehicelsController(WorkoutContext context)
        {
            _context = context;
        }

        // GET: api/Vehicels
        [HttpGet]
        public IEnumerable<Vehicel> GetVehicel()
        {
            return _context.Vehicel;
        }

        // GET: api/Vehicels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehicel = await _context.Vehicel.FindAsync(id);

            if (vehicel == null)
            {
                return NotFound();
            }

            return Ok(vehicel);
        }

        // PUT: api/Vehicels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicel([FromRoute] int id, [FromBody] Vehicel vehicel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicel.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehicel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicelExists(id))
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

        // POST: api/Vehicels
        [HttpPost]
        public async Task<IActionResult> PostVehicel([FromBody] Vehicel vehicel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vehicel.Add(vehicel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicel", new { id = vehicel.Id }, vehicel);
        }

        // DELETE: api/Vehicels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehicel = await _context.Vehicel.FindAsync(id);
            if (vehicel == null)
            {
                return NotFound();
            }

            _context.Vehicel.Remove(vehicel);
            await _context.SaveChangesAsync();

            return Ok(vehicel);
        }

        private bool VehicelExists(int id)
        {
            return _context.Vehicel.Any(e => e.Id == id);
        }
    }
}