using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Flomak.com.tr.Models;

namespace Flomak.com.tr.Controllers
{
    public class ReferencesController : Controller
    {
        private readonly Context _context;

        public ReferencesController(Context context)
        {
            _context = context;
        }

        // GET: References
        public async Task<IActionResult> Index()
        {
            return View(await _context.References.ToListAsync());
        }

        // GET: References/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reference == null)
            {
                return NotFound();
            }

            return View(reference);
        }

        // GET: References/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: References/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Image,Text")] Reference reference)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reference);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reference);
        }

        // GET: References/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References.FindAsync(id);
            if (reference == null)
            {
                return NotFound();
            }
            return View(reference);
        }

        // POST: References/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Image,Text")] Reference reference)
        {
            if (id != reference.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reference);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceExists(reference.ID))
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
            return View(reference);
        }

        // GET: References/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reference = await _context.References
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reference == null)
            {
                return NotFound();
            }

            return View(reference);
        }

        // POST: References/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reference = await _context.References.FindAsync(id);
            _context.References.Remove(reference);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferenceExists(int id)
        {
            return _context.References.Any(e => e.ID == id);
        }
    }
}
