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
    public class KhuyenMaiController : Controller
    {
        private readonly StoreContext _context;

        public KhuyenMaiController(StoreContext context)
        {
            _context = context;
        }

        // GET: KhuyenMai
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhuyenMais.ToListAsync());
        }

        // GET: KhuyenMai/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khuyenMaiModel = await _context.KhuyenMais
                .FirstOrDefaultAsync(m => m.maKM == id);
            if (khuyenMaiModel == null)
            {
                return NotFound();
            }

            return View(khuyenMaiModel);
        }

        // GET: KhuyenMai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhuyenMai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maKM,tenKM,phanTram,ngayBatDau,hieuLuc,daXoa")] KhuyenMaiModel khuyenMaiModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khuyenMaiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khuyenMaiModel);
        }

        // GET: KhuyenMai/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khuyenMaiModel = await _context.KhuyenMais.FindAsync(id);
            if (khuyenMaiModel == null)
            {
                return NotFound();
            }
            return View(khuyenMaiModel);
        }

        // POST: KhuyenMai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maKM,tenKM,phanTram,ngayBatDau,hieuLuc,daXoa")] KhuyenMaiModel khuyenMaiModel)
        {
            if (id != khuyenMaiModel.maKM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khuyenMaiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhuyenMaiModelExists(khuyenMaiModel.maKM))
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
            return View(khuyenMaiModel);
        }

        // GET: KhuyenMai/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khuyenMaiModel = await _context.KhuyenMais
                .FirstOrDefaultAsync(m => m.maKM == id);
            if (khuyenMaiModel == null)
            {
                return NotFound();
            }

            return View(khuyenMaiModel);
        }

        // POST: KhuyenMai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khuyenMaiModel = await _context.KhuyenMais.FindAsync(id);
            _context.KhuyenMais.Remove(khuyenMaiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhuyenMaiModelExists(string id)
        {
            return _context.KhuyenMais.Any(e => e.maKM == id);
        }
    }
}
