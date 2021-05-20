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
    public class FlomakSectorsController : Controller
    {
        private readonly Context _context;

        public FlomakSectorsController(Context context)
        {
            _context = context;
        }

        // GET: FlomakSectors
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlomakSectors.ToListAsync());
        }

        // GET: FlomakSectors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flomakSector = await _context.FlomakSectors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (flomakSector == null)
            {
                return NotFound();
            }

            return View(flomakSector);
        }

        // GET: FlomakSectors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlomakSectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Image,SectorName,SectorCategory,Label,User,History")] FlomakSector flomakSector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flomakSector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flomakSector);
        }

        // GET: FlomakSectors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flomakSector = await _context.FlomakSectors.FindAsync(id);
            if (flomakSector == null)
            {
                return NotFound();
            }
            return View(flomakSector);
        }

        // POST: FlomakSectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Image,SectorName,SectorCategory,Label,User,History")] FlomakSector flomakSector)
        {
            if (id != flomakSector.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flomakSector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlomakSectorExists(flomakSector.ID))
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
            return View(flomakSector);
        }

        // GET: FlomakSectors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flomakSector = await _context.FlomakSectors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (flomakSector == null)
            {
                return NotFound();
            }

            return View(flomakSector);
        }

        // POST: FlomakSectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flomakSector = await _context.FlomakSectors.FindAsync(id);
            _context.FlomakSectors.Remove(flomakSector);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlomakSectorExists(int id)
        {
            return _context.FlomakSectors.Any(e => e.ID == id);
        }
    }
}
