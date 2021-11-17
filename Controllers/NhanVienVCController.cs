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
    public class NhanVienVCController : Controller
    {
        private readonly StoreContext _context;

        public NhanVienVCController(StoreContext context)
        {
            _context = context;
        }

        // GET: NhanVienVC
        public async Task<IActionResult> Index()
        {
            return View(await _context.NhanVienVCs.ToListAsync());
        }

        // GET: NhanVienVC/Details/5
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

        // GET: NhanVienVC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhanVienVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: NhanVienVC/Edit/5
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

        // POST: NhanVienVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: NhanVienVC/Delete/5
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

        // POST: NhanVienVC/Delete/5
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
