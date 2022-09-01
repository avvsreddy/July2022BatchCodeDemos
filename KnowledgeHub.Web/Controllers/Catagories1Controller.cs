using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;

namespace KnowledgeHub.Web.Controllers
{
    public class Catagories1Controller : Controller
    {
        private readonly KnowledgeHubDbContext _context;

        public Catagories1Controller(KnowledgeHubDbContext context)
        {
            _context = context;
        }

        // GET: Catagories1
        public async Task<IActionResult> Index()
        {
              return View(await _context.Catagories.ToListAsync());
        }

        // GET: Catagories1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Catagories == null)
            {
                return NotFound();
            }

            var catagory = await _context.Catagories
                .FirstOrDefaultAsync(m => m.CatagoryID == id);
            if (catagory == null)
            {
                return NotFound();
            }

            return View(catagory);
        }

        // GET: Catagories1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catagories1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatagoryID,Name,Description")] Catagory catagory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catagory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catagory);
        }

        // GET: Catagories1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Catagories == null)
            {
                return NotFound();
            }

            var catagory = await _context.Catagories.FindAsync(id);
            if (catagory == null)
            {
                return NotFound();
            }
            return View(catagory);
        }

        // POST: Catagories1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatagoryID,Name,Description")] Catagory catagory)
        {
            if (id != catagory.CatagoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catagory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatagoryExists(catagory.CatagoryID))
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
            return View(catagory);
        }

        // GET: Catagories1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Catagories == null)
            {
                return NotFound();
            }

            var catagory = await _context.Catagories
                .FirstOrDefaultAsync(m => m.CatagoryID == id);
            if (catagory == null)
            {
                return NotFound();
            }

            return View(catagory);
        }

        // POST: Catagories1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Catagories == null)
            {
                return Problem("Entity set 'KnowledgeHubDbContext.Catagories'  is null.");
            }
            var catagory = await _context.Catagories.FindAsync(id);
            if (catagory != null)
            {
                _context.Catagories.Remove(catagory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatagoryExists(int id)
        {
          return _context.Catagories.Any(e => e.CatagoryID == id);
        }
    }
}
