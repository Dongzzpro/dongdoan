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
    public class HocViensController : ControllerBase
    {
        private readonly QuanLyGhiDanhContext _context;

        public HocViensController(QuanLyGhiDanhContext context)
        {
            _context = context;
        }

        // GET: api/HocViens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HocVien>>> GetHocViens()
        {
            return await _context.HocViens.ToListAsync();
        }

        // GET: api/HocViens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HocVien>> GetHocVien(int id)
        {
            var hocVien = await _context.HocViens.FindAsync(id);

            if (hocVien == null)
            {
                return NotFound();
            }

            return hocVien;
        }

        // PUT: api/HocViens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHocVien(int id, HocVien hocVien)
        {
            if (id != hocVien.IdHocVien)
            {
                return BadRequest();
            }

            _context.Entry(hocVien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HocVienExists(id))
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

        // POST: api/HocViens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HocVien>> PostHocVien(HocVien hocVien)
        {
            _context.HocViens.Add(hocVien);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHocVien", new { id = hocVien.IdHocVien }, hocVien);
        }

        // DELETE: api/HocViens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHocVien(int id)
        {
            var hocVien = await _context.HocViens.FindAsync(id);
            if (hocVien == null)
            {
                return NotFound();
            }

            _context.HocViens.Remove(hocVien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HocVienExists(int id)
        {
            return _context.HocViens.Any(e => e.IdHocVien == id);
        }
    }
}
