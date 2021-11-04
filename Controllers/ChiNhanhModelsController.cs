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
    public class ChiNhanhModelsController : Controller
    {
        private readonly StoreContext _context;

        public ChiNhanhModelsController(StoreContext context)
        {
            _context = context;
        }

        // GET: ChiNhanhModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiNhanhs.ToListAsync());
        }

        // GET: ChiNhanhModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiNhanhModel = await _context.ChiNhanhs
                .FirstOrDefaultAsync(m => m.maChiNhanh == id);
            if (chiNhanhModel == null)
            {
                return NotFound();
            }

            return View(chiNhanhModel);
        }

        // GET: ChiNhanhModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiNhanhModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maChiNhanh,tenChiNhanh,diaChi,SDT,ngayThanhLap,truongCN,daXoa")] ChiNhanhModel chiNhanhModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiNhanhModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiNhanhModel);
        }

        // GET: ChiNhanhModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiNhanhModel = await _context.ChiNhanhs.FindAsync(id);
            if (chiNhanhModel == null)
            {
                return NotFound();
            }
            return View(chiNhanhModel);
        }

        // POST: ChiNhanhModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maChiNhanh,tenChiNhanh,diaChi,SDT,ngayThanhLap,truongCN,daXoa")] ChiNhanhModel chiNhanhModel)
        {
            if (id != chiNhanhModel.maChiNhanh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiNhanhModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiNhanhModelExists(chiNhanhModel.maChiNhanh))
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
            return View(chiNhanhModel);
        }

        // GET: ChiNhanhModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiNhanhModel = await _context.ChiNhanhs
                .FirstOrDefaultAsync(m => m.maChiNhanh == id);
            if (chiNhanhModel == null)
            {
                return NotFound();
            }

            return View(chiNhanhModel);
        }

        // POST: ChiNhanhModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chiNhanhModel = await _context.ChiNhanhs.FindAsync(id);
            _context.ChiNhanhs.Remove(chiNhanhModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiNhanhModelExists(string id)
        {
            return _context.ChiNhanhs.Any(e => e.maChiNhanh == id);
        }
    }
}
