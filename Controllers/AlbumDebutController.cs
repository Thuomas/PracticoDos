using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TPDos.Data;
using TPdos.Models;

namespace TPdos.Controllers
{
    public class AlbumDebutController : Controller
    {
        private readonly ArtistaContext _context;

        public AlbumDebutController(ArtistaContext context)
        {
            _context = context;
        }

        // GET: AlbumDebut
        public async Task<IActionResult> Index()
        {
              return _context.AlbumDebut != null ? 
                          View(await _context.AlbumDebut.ToListAsync()) :
                          Problem("Entity set 'ArtistaContext.AlbumDebut'  is null.");
        }

        // GET: AlbumDebut/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AlbumDebut == null)
            {
                return NotFound();
            }

            var albumDebut = await _context.AlbumDebut
                .FirstOrDefaultAsync(m => m.Id == id);
            if (albumDebut == null)
            {
                return NotFound();
            }

            return View(albumDebut);
        }

        // GET: AlbumDebut/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlbumDebut/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,AnioLanzamiento,BandaId")] AlbumDebut albumDebut)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumDebut);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(albumDebut);
        }

        // GET: AlbumDebut/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AlbumDebut == null)
            {
                return NotFound();
            }

            var albumDebut = await _context.AlbumDebut.FindAsync(id);
            if (albumDebut == null)
            {
                return NotFound();
            }
            return View(albumDebut);
        }

        // POST: AlbumDebut/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,AnioLanzamiento,BandaId")] AlbumDebut albumDebut)
        {
            if (id != albumDebut.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumDebut);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumDebutExists(albumDebut.Id))
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
            return View(albumDebut);
        }

        // GET: AlbumDebut/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AlbumDebut == null)
            {
                return NotFound();
            }

            var albumDebut = await _context.AlbumDebut
                .FirstOrDefaultAsync(m => m.Id == id);
            if (albumDebut == null)
            {
                return NotFound();
            }

            return View(albumDebut);
        }

        // POST: AlbumDebut/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AlbumDebut == null)
            {
                return Problem("Entity set 'ArtistaContext.AlbumDebut'  is null.");
            }
            var albumDebut = await _context.AlbumDebut.FindAsync(id);
            if (albumDebut != null)
            {
                _context.AlbumDebut.Remove(albumDebut);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumDebutExists(int id)
        {
          return (_context.AlbumDebut?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
