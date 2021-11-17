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
    public class UuserController : Controller
    {
        private readonly StoreContext _context;

        public UuserController(StoreContext context)
        {
            _context = context;
        }

        // GET: Uuser
        public async Task<IActionResult> Index()
        {
            return View(await _context.Uusers.ToListAsync());
        }

        // GET: Uuser/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uuserModel = await _context.Uusers
                .FirstOrDefaultAsync(m => m.maUser == id);
            if (uuserModel == null)
            {
                return NotFound();
            }

            return View(uuserModel);
        }

        // GET: Uuser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Uuser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maUser,maKH,maNV,maNVVC,uuserName,ppassWord,uUPDATE,cCREATE,daXoa")] UuserModel uuserModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uuserModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uuserModel);
        }

        // GET: Uuser/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uuserModel = await _context.Uusers.FindAsync(id);
            if (uuserModel == null)
            {
                return NotFound();
            }
            return View(uuserModel);
        }

        // POST: Uuser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("maUser,maKH,maNV,maNVVC,uuserName,ppassWord,uUPDATE,cCREATE,daXoa")] UuserModel uuserModel)
        {
            if (id != uuserModel.maUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uuserModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UuserModelExists(uuserModel.maUser))
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
            return View(uuserModel);
        }

        // GET: Uuser/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uuserModel = await _context.Uusers
                .FirstOrDefaultAsync(m => m.maUser == id);
            if (uuserModel == null)
            {
                return NotFound();
            }

            return View(uuserModel);
        }

        // POST: Uuser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var uuserModel = await _context.Uusers.FindAsync(id);
            _context.Uusers.Remove(uuserModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UuserModelExists(string id)
        {
            return _context.Uusers.Any(e => e.maUser == id);
        }
    }
}
