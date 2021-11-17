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
    public class GioHangController : Controller
    {
        private readonly StoreContext _context;

        public GioHangController(StoreContext context)
        {
            _context = context;
        }

        // GET: GioHang
        public async Task<IActionResult> Index()
        {
            return View(await _context.GioHangs.ToListAsync());
        }

        // GET: GioHang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHangModel = await _context.GioHangs
                .FirstOrDefaultAsync(m => m.maKH == id);
            if (gioHangModel == null)
            {
                return NotFound();
            }

            return View(gioHangModel);
        }

        // GET: GioHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GioHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maKH,maSP,soLuong")] GioHangModel gioHangModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gioHangModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gioHangModel);
        }

        // GET: GioHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHangModel = await _context.GioHangs.FindAsync(id);
            if (gioHangModel == null)
            {
                return NotFound();
            }
            return View(gioHangModel);
        }

        // POST: GioHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maKH,maSP,soLuong")] GioHangModel gioHangModel)
        {
            if (id != gioHangModel.maKH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gioHangModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GioHangModelExists(gioHangModel.maKH))
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
            return View(gioHangModel);
        }

        // GET: GioHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHangModel = await _context.GioHangs
                .FirstOrDefaultAsync(m => m.maKH == id);
            if (gioHangModel == null)
            {
                return NotFound();
            }

            return View(gioHangModel);
        }

        // POST: GioHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var gioHangModel = await _context.GioHangs.FindAsync(id);
            _context.GioHangs.Remove(gioHangModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GioHangModelExists(string id)
        {
            return _context.GioHangs.Any(e => e.maKH == id);
        }
    }
}
