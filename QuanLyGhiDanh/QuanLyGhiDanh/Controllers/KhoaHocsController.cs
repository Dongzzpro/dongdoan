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
    public class KhoaHocsController : ControllerBase
    {
        private readonly QuanLyGhiDanhContext _context;

        public KhoaHocsController(QuanLyGhiDanhContext context)
        {
            _context = context;
        }

        // GET: api/KhoaHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KhoaHoc>>> GetKhoaHocs()
        {
            return await _context.KhoaHocs.ToListAsync();
        }

        // GET: api/KhoaHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KhoaHoc>> GetKhoaHoc(int id)
        {
            var khoaHoc = await _context.KhoaHocs.FindAsync(id);

            if (khoaHoc == null)
            {
                return NotFound();
            }

            return khoaHoc;
        }

        // PUT: api/KhoaHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhoaHoc(int id, KhoaHoc khoaHoc)
        {
            if (id != khoaHoc.IdKhoaHoc)
            {
                return BadRequest();
            }

            _context.Entry(khoaHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhoaHocExists(id))
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

        // POST: api/KhoaHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KhoaHoc>> PostKhoaHoc(KhoaHoc khoaHoc)
        {
            _context.KhoaHocs.Add(khoaHoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhoaHoc", new { id = khoaHoc.IdKhoaHoc }, khoaHoc);
        }

        // DELETE: api/KhoaHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhoaHoc(int id)
        {
            var khoaHoc = await _context.KhoaHocs.FindAsync(id);
            if (khoaHoc == null)
            {
                return NotFound();
            }

            _context.KhoaHocs.Remove(khoaHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhoaHocExists(int id)
        {
            return _context.KhoaHocs.Any(e => e.IdKhoaHoc == id);
        }
    }
}
