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
    public class SanPhamController : Controller
    {
        private readonly StoreContext _context;

        public SanPhamController(StoreContext context)
        {
            _context = context;
        }

        // GET: SanPham
        public async Task<IActionResult> Index()
        {
            return View(await _context.SanPhams.ToListAsync());
        }

        // GET: SanPham/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPhams
                .FirstOrDefaultAsync(m => m.maSP == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // GET: SanPham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maSP,tenSP,hangSX,mauSac,dungLuong,RAM,CAMERA,BLUETOOTH,soLuong,GIA,giaKM,maChuongTrinh,anh1,anh2,anh3,anh4,namSX,maChiNhanh,ghiChu,daXoa")] SanPhamModel sanPhamModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanPhamModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanPhamModel);
        }

        // GET: SanPham/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPhams.FindAsync(id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }
            return View(sanPhamModel);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maSP,tenSP,hangSX,mauSac,dungLuong,RAM,CAMERA,BLUETOOTH,soLuong,GIA,giaKM,maChuongTrinh,anh1,anh2,anh3,anh4,namSX,maChiNhanh,ghiChu,daXoa")] SanPhamModel sanPhamModel)
        {
            if (id != sanPhamModel.maSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPhamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamModelExists(sanPhamModel.maSP))
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
            return View(sanPhamModel);
        }

        // GET: SanPham/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPhams
                .FirstOrDefaultAsync(m => m.maSP == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sanPhamModel = await _context.SanPhams.FindAsync(id);
            _context.SanPhams.Remove(sanPhamModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamModelExists(string id)
        {
            return _context.SanPhams.Any(e => e.maSP == id);
        }
    }
}
