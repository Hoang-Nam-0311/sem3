using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_Sem3.Models;

namespace Project_SemIII.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuoteUsController : Controller
    {
        private readonly ProjectDbContext _context;

        public QuoteUsController(ProjectDbContext context)
        {
            _context = context;
        }

        // GET: Admin/QuoteUs
        public async Task<IActionResult> Index()
        {
              return _context.QuoteUs != null ? 
                          View(await _context.QuoteUs.ToListAsync()) :
                          Problem("Entity set 'ProjectDbContext.QuoteUs'  is null.");
        }

        // GET: Admin/QuoteUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.QuoteUs == null)
            {
                return NotFound();
            }

            var quoteUs = await _context.QuoteUs
                .FirstOrDefaultAsync(m => m.QuoteId == id);
            if (quoteUs == null)
            {
                return NotFound();
            }

            return View(quoteUs);
        }

        // GET: Admin/QuoteUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuoteUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuoteId,FullName,CompanyName,Address,City,State,PostalCode,Country,EmailAddress,Phone,Comments")] QuoteUs quoteUs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quoteUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quoteUs);
        }

        // GET: Admin/QuoteUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.QuoteUs == null)
            {
                return NotFound();
            }

            var quoteUs = await _context.QuoteUs.FindAsync(id);
            if (quoteUs == null)
            {
                return NotFound();
            }
            return View(quoteUs);
        }

        // POST: Admin/QuoteUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuoteId,FullName,CompanyName,Address,City,State,PostalCode,Country,EmailAddress,Phone,Comments")] QuoteUs quoteUs)
        {
            if (id != quoteUs.QuoteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quoteUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuoteUsExists(quoteUs.QuoteId))
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
            return View(quoteUs);
        }

        // GET: Admin/QuoteUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.QuoteUs == null)
            {
                return NotFound();
            }

            var quoteUs = await _context.QuoteUs
                .FirstOrDefaultAsync(m => m.QuoteId == id);
            if (quoteUs == null)
            {
                return NotFound();
            }

            return View(quoteUs);
        }

        // POST: Admin/QuoteUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.QuoteUs == null)
            {
                return Problem("Entity set 'ProjectDbContext.QuoteUs'  is null.");
            }
            var quoteUs = await _context.QuoteUs.FindAsync(id);
            if (quoteUs != null)
            {
                _context.QuoteUs.Remove(quoteUs);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuoteUsExists(int id)
        {
          return (_context.QuoteUs?.Any(e => e.QuoteId == id)).GetValueOrDefault();
        }
    }
}
