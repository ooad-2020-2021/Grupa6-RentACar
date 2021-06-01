using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentAndGo.Data;
using RentAndGo.Models;

namespace RentAndGo.Controllers
{
    public class BankovniRacunController : Controller
    {
        private readonly DataContext _context;

        public BankovniRacunController(DataContext context)
        {
            _context = context;
        }

        // GET: BankovniRacun
        public async Task<IActionResult> Index()
        {
            return View(await _context.BankovniRacun.ToListAsync());
        }

        // GET: BankovniRacun/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankovniRacun = await _context.BankovniRacun
                .FirstOrDefaultAsync(m => m.BrojRacuna == id);
            if (bankovniRacun == null)
            {
                return NotFound();
            }

            return View(bankovniRacun);
        }

        // GET: BankovniRacun/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BankovniRacun/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrojRacuna,DatumValidnostiKartice,ImePrezime,JMB")] BankovniRacun bankovniRacun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankovniRacun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankovniRacun);
        }

        // GET: BankovniRacun/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankovniRacun = await _context.BankovniRacun.FindAsync(id);
            if (bankovniRacun == null)
            {
                return NotFound();
            }
            return View(bankovniRacun);
        }

        // POST: BankovniRacun/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BrojRacuna,DatumValidnostiKartice,ImePrezime,JMB")] BankovniRacun bankovniRacun)
        {
            if (id != bankovniRacun.BrojRacuna)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankovniRacun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankovniRacunExists(bankovniRacun.BrojRacuna))
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
            return View(bankovniRacun);
        }

        // GET: BankovniRacun/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankovniRacun = await _context.BankovniRacun
                .FirstOrDefaultAsync(m => m.BrojRacuna == id);
            if (bankovniRacun == null)
            {
                return NotFound();
            }

            return View(bankovniRacun);
        }

        // POST: BankovniRacun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bankovniRacun = await _context.BankovniRacun.FindAsync(id);
            _context.BankovniRacun.Remove(bankovniRacun);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankovniRacunExists(string id)
        {
            return _context.BankovniRacun.Any(e => e.BrojRacuna == id);
        }
    }
}
