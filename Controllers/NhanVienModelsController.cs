using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLW.Data;
using QLW.Models;

namespace QLW.Controllers
{
    public class NhanVienModelsController : Controller
    {
        private readonly StoreContext _context;

        public NhanVienModelsController(StoreContext context)
        {
            _context = context;
        }

        // GET: NhanVienModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.NhanViens.ToListAsync());
        }

        // GET: NhanVienModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienModel = await _context.NhanViens
                .FirstOrDefaultAsync(m => m.maNV == id);
            if (nhanVienModel == null)
            {
                return NotFound();
            }

            return View(nhanVienModel);
        }

        // GET: NhanVienModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhanVienModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maNV,tenNV,ngaySinh,diaChi,SDT,gioiTinh,luongCoBan,chucVu,maChiNhanh,daXoa")] NhanVienModel nhanVienModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVienModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhanVienModel);
        }

        // GET: NhanVienModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienModel = await _context.NhanViens.FindAsync(id);
            if (nhanVienModel == null)
            {
                return NotFound();
            }
            return View(nhanVienModel);
        }

        // POST: NhanVienModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maNV,tenNV,ngaySinh,diaChi,SDT,gioiTinh,luongCoBan,chucVu,maChiNhanh,daXoa")] NhanVienModel nhanVienModel)
        {
            if (id != nhanVienModel.maNV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVienModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienModelExists(nhanVienModel.maNV))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nhanVienModel);
        }

        // GET: NhanVienModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienModel = await _context.NhanViens
                .FirstOrDefaultAsync(m => m.maNV == id);
            if (nhanVienModel == null)
            {
                return NotFound();
            }

            return View(nhanVienModel);
        }

        // POST: NhanVienModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhanVienModel = await _context.NhanViens.FindAsync(id);
            _context.NhanViens.Remove(nhanVienModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienModelExists(string id)
        {
            return _context.NhanViens.Any(e => e.maNV == id);
        }
    }
}
