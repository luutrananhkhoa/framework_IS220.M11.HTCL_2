using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLW.Data;
using QLW.Models;

namespace QLW.Controllers
{
    public class KhachHangModelsController : Controller
    {
        private readonly StoreContext _context;

        public KhachHangModelsController(StoreContext context)
        {
            _context = context;
        }

        // GET: KhachHangModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhachHangs.ToListAsync());
        }

        // GET: KhachHangModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangModel = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.maKH == id);
            if (khachHangModel == null)
            {
                return NotFound();
            }

            return View(khachHangModel);
        }

        // GET: KhachHangModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhachHangModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maKH,tenKH,ngaySinh,diaChi,SDT,gioiTinh,diemTichLuy,loaiKhachHang,CMND,hinhChup,daXoa")] KhachHangModel khachHangModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachHangModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachHangModel);
        }

        // GET: KhachHangModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangModel = await _context.KhachHangs.FindAsync(id);
            if (khachHangModel == null)
            {
                return NotFound();
            }
            return View(khachHangModel);
        }

        // POST: KhachHangModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maKH,tenKH,ngaySinh,diaChi,SDT,gioiTinh,diemTichLuy,loaiKhachHang,CMND,hinhChup,daXoa")] KhachHangModel khachHangModel)
        {
            if (id != khachHangModel.maKH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHangModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangModelExists(khachHangModel.maKH))
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
            return View(khachHangModel);
        }

        // GET: KhachHangModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangModel = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.maKH == id);
            if (khachHangModel == null)
            {
                return NotFound();
            }

            return View(khachHangModel);
        }

        // POST: KhachHangModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khachHangModel = await _context.KhachHangs.FindAsync(id);
            _context.KhachHangs.Remove(khachHangModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangModelExists(string id)
        {
            return _context.KhachHangs.Any(e => e.maKH == id);
        }
    }
}
