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
    public class ChiTietHoaDonController : Controller
    {
        private readonly StoreContext _context;

        public ChiTietHoaDonController(StoreContext context)
        {
            _context = context;
        }

        // GET: ChiTietHoaDon
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietHoaDons.ToListAsync());
        }

        // GET: ChiTietHoaDon/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDons
                .FirstOrDefaultAsync(m => m.soHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // GET: ChiTietHoaDon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiTietHoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("soHD,maSP,soLuong,thanhTien")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHoaDonModel);
        }

        // GET: ChiTietHoaDon/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDons.FindAsync(id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }
            return View(chiTietHoaDonModel);
        }

        // POST: ChiTietHoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("soHD,maSP,soLuong,thanhTien")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (id != chiTietHoaDonModel.soHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonModelExists(chiTietHoaDonModel.soHD))
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
            return View(chiTietHoaDonModel);
        }

        // GET: ChiTietHoaDon/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDons
                .FirstOrDefaultAsync(m => m.soHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // POST: ChiTietHoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chiTietHoaDonModel = await _context.ChiTietHoaDons.FindAsync(id);
            _context.ChiTietHoaDons.Remove(chiTietHoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonModelExists(string id)
        {
            return _context.ChiTietHoaDons.Any(e => e.soHD == id);
        }
    }
}
