using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KLKLKL.Models;
using Tcontext.Data;

namespace KLKLKL.Controllers
{
    public class cau1Controller : Controller
    {
        private readonly ApplicationDbContext _context;
          Toupper abc = new Toupper();
        public cau1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: cau1
        public async Task<IActionResult> Index()
        {
            return View(await _context.cau1.ToListAsync());
        }

        // GET: cau1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cau1 = await _context.cau1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cau1 == null)
            {
                return NotFound();
            }

            return View(cau1);
        }

        // GET: cau1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cau1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Heigh")] cau1 cau1)
        {
            if (ModelState.IsValid)
            {
                cau1.Name = abc.AutoUpper(cau1.Name);
                _context.Add(cau1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cau1);
        }

        // GET: cau1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cau1 = await _context.cau1.FindAsync(id);
            if (cau1 == null)
            {
                return NotFound();
            }
            return View(cau1);
        }

        // POST: cau1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Heigh")] cau1 cau1)
        {
            if (id != cau1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cau1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cau1Exists(cau1.Id))
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
            return View(cau1);
        }

        // GET: cau1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cau1 = await _context.cau1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cau1 == null)
            {
                return NotFound();
            }

            return View(cau1);
        }

        // POST: cau1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cau1 = await _context.cau1.FindAsync(id);
            if (cau1 != null)
            {
                _context.cau1.Remove(cau1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cau1Exists(int id)
        {
            return _context.cau1.Any(e => e.Id == id);
        }
    }
}
