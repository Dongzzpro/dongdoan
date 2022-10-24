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
    public class LopHocsController : ControllerBase
    {
        private readonly QuanLyGhiDanhContext _context;

        public LopHocsController(QuanLyGhiDanhContext context)
        {
            _context = context;
        }

        // GET: api/LopHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LopHoc>>> GetLopHocs()
        {
            return await _context.LopHocs.ToListAsync();
        }

        // GET: api/LopHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LopHoc>> GetLopHoc(int id)
        {
            var lopHoc = await _context.LopHocs.FindAsync(id);

            if (lopHoc == null)
            {
                return NotFound();
            }

            return lopHoc;
        }

        // PUT: api/LopHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLopHoc(int id, LopHoc lopHoc)
        {
            if (id != lopHoc.IdLopHoc)
            {
                return BadRequest();
            }

            _context.Entry(lopHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LopHocExists(id))
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

        // POST: api/LopHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LopHoc>> PostLopHoc(LopHoc lopHoc)
        {
            _context.LopHocs.Add(lopHoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLopHoc", new { id = lopHoc.IdLopHoc }, lopHoc);
        }

        // DELETE: api/LopHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLopHoc(int id)
        {
            var lopHoc = await _context.LopHocs.FindAsync(id);
            if (lopHoc == null)
            {
                return NotFound();
            }

            _context.LopHocs.Remove(lopHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LopHocExists(int id)
        {
            return _context.LopHocs.Any(e => e.IdLopHoc == id);
        }
    }
}
