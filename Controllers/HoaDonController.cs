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
    public class HoaDonController : Controller
    {
        private readonly StoreContext _context;

        public HoaDonController(StoreContext context)
        {
            _context = context;
        }

        // GET: HoaDon
        public async Task<IActionResult> Index()
        {
            return View(await _context.HoaDons.ToListAsync());
        }

        // GET: HoaDon/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDons
                .FirstOrDefaultAsync(m => m.soHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // GET: HoaDon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("soHD,maKH,maNVVC,khauTru,maNV,tongGia,tongSL,tinhTrang,ngayLapHD,ngayHoanTat,daXoa")] HoaDonModel hoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoaDonModel);
        }

        // GET: HoaDon/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDons.FindAsync(id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }
            return View(hoaDonModel);
        }

        // POST: HoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("soHD,maKH,maNVVC,khauTru,maNV,tongGia,tongSL,tinhTrang,ngayLapHD,ngayHoanTat,daXoa")] HoaDonModel hoaDonModel)
        {
            if (id != hoaDonModel.soHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonModelExists(hoaDonModel.soHD))
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
            return View(hoaDonModel);
        }

        // GET: HoaDon/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDons
                .FirstOrDefaultAsync(m => m.soHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // POST: HoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hoaDonModel = await _context.HoaDons.FindAsync(id);
            _context.HoaDons.Remove(hoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonModelExists(string id)
        {
            return _context.HoaDons.Any(e => e.soHD == id);
        }
    }
}
