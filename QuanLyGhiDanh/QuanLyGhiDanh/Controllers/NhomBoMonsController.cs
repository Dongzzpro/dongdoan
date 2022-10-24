using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyGhiDanh.Data;

namespace QuanLyGhiDanh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhomBoMonsController : ControllerBase
    {
        private readonly QuanLyGhiDanhContext _context;

        public NhomBoMonsController(QuanLyGhiDanhContext context)
        {
            _context = context;
        }

        // GET: api/NhomBoMons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhomBoMon>>> GetNhomBoMons()
        {
            return await _context.NhomBoMons.ToListAsync();
        }

        // GET: api/NhomBoMons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhomBoMon>> GetNhomBoMon(int id)
        {
            var nhomBoMon = await _context.NhomBoMons.FindAsync(id);

            if (nhomBoMon == null)
            {
                return NotFound();
            }

            return nhomBoMon;
        }

        // PUT: api/NhomBoMons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhomBoMon(int id, NhomBoMon nhomBoMon)
        {
            if (id != nhomBoMon.IdNhomBoMon)
            {
                return BadRequest();
            }

            _context.Entry(nhomBoMon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhomBoMonExists(id))
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

        // POST: api/NhomBoMons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NhomBoMon>> PostNhomBoMon(NhomBoMon nhomBoMon)
        {
            _context.NhomBoMons.Add(nhomBoMon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNhomBoMon", new { id = nhomBoMon.IdNhomBoMon }, nhomBoMon);
        }

        // DELETE: api/NhomBoMons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhomBoMon(int id)
        {
            var nhomBoMon = await _context.NhomBoMons.FindAsync(id);
            if (nhomBoMon == null)
            {
                return NotFound();
            }

            _context.NhomBoMons.Remove(nhomBoMon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhomBoMonExists(int id)
        {
            return _context.NhomBoMons.Any(e => e.IdNhomBoMon == id);
        }
    }
}
