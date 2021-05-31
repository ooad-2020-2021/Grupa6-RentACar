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
    public class PrijavaController : Controller
    {
        private readonly DataContext _context;

        public PrijavaController(DataContext context)
        {
            _context = context;
        }

        // GET: Prijava
        public async Task<IActionResult> Index()
        {
            return View(await _context.KorisnikSaNalogom.ToListAsync());
        }

        // GET: Prijava/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikSaNalogom = await _context.KorisnikSaNalogom
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnikSaNalogom == null)
            {
                return NotFound();
            }

            return View(korisnikSaNalogom);
        }

        // GET: Prijava/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prijava/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ime,Prezime,DatumRodjenja,Lozinka,Email,BrojTelefona,SlikaKorisnika,BrojVozackeDozvole")] KorisnikSaNalogom korisnikSaNalogom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnikSaNalogom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnikSaNalogom);
        }

        // GET: Prijava/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikSaNalogom = await _context.KorisnikSaNalogom.FindAsync(id);
            if (korisnikSaNalogom == null)
            {
                return NotFound();
            }
            return View(korisnikSaNalogom);
        }

        // POST: Prijava/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ime,Prezime,DatumRodjenja,Lozinka,Email,BrojTelefona,SlikaKorisnika,BrojVozackeDozvole")] KorisnikSaNalogom korisnikSaNalogom)
        {
            if (id != korisnikSaNalogom.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korisnikSaNalogom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisnikSaNalogomExists(korisnikSaNalogom.ID))
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
            return View(korisnikSaNalogom);
        }

        // GET: Prijava/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikSaNalogom = await _context.KorisnikSaNalogom
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnikSaNalogom == null)
            {
                return NotFound();
            }

            return View(korisnikSaNalogom);
        }

        // POST: Prijava/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korisnikSaNalogom = await _context.KorisnikSaNalogom.FindAsync(id);
            _context.KorisnikSaNalogom.Remove(korisnikSaNalogom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisnikSaNalogomExists(int id)
        {
            return _context.KorisnikSaNalogom.Any(e => e.ID == id);
        }
    }
}
