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
    public class NhanVienVCModelsController : Controller
    {
        private readonly StoreContext _context;

        public NhanVienVCModelsController(StoreContext context)
        {
            _context = context;
        }

        // GET: NhanVienVCModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.NhanVienVCs.ToListAsync());
        }

        // GET: NhanVienVCModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienVCModel = await _context.NhanVienVCs
                .FirstOrDefaultAsync(m => m.maNVVC == id);
            if (nhanVienVCModel == null)
            {
                return NotFound();
            }

            return View(nhanVienVCModel);
        }

        // GET: NhanVienVCModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhanVienVCModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maNVVC,tenNVVC,ngaySinh,diaChi,SDT,gioiTinh,luongCoBan,daXoa")] NhanVienVCModel nhanVienVCModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVienVCModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhanVienVCModel);
        }

        // GET: NhanVienVCModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienVCModel = await _context.NhanVienVCs.FindAsync(id);
            if (nhanVienVCModel == null)
            {
                return NotFound();
            }
            return View(nhanVienVCModel);
        }

        // POST: NhanVienVCModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maNVVC,tenNVVC,ngaySinh,diaChi,SDT,gioiTinh,luongCoBan,daXoa")] NhanVienVCModel nhanVienVCModel)
        {
            if (id != nhanVienVCModel.maNVVC)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVienVCModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienVCModelExists(nhanVienVCModel.maNVVC))
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
            return View(nhanVienVCModel);
        }

        // GET: NhanVienVCModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVienVCModel = await _context.NhanVienVCs
                .FirstOrDefaultAsync(m => m.maNVVC == id);
            if (nhanVienVCModel == null)
            {
                return NotFound();
            }

            return View(nhanVienVCModel);
        }

        // POST: NhanVienVCModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhanVienVCModel = await _context.NhanVienVCs.FindAsync(id);
            _context.NhanVienVCs.Remove(nhanVienVCModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienVCModelExists(string id)
        {
            return _context.NhanVienVCs.Any(e => e.maNVVC == id);
        }
    }
}
