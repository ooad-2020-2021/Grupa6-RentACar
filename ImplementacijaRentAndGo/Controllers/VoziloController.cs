using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImplementacijaRentAndGo.Data;
using ImplementacijaRentAndGo.Models;
using Microsoft.AspNetCore.Authorization;

namespace ImplementacijaRentAndGo.Controllers
{
    public class VoziloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoziloController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Administrator")]
        // GET: Vozilo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vozilo.ToListAsync());
        }

        [Authorize(Roles = "Administrator")]
        // GET: Vozilo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vozilo = await _context.Vozilo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vozilo == null)
            {
                return NotFound();
            }

            return View(vozilo);
        }

        [Authorize(Roles = "Administrator")]
        // GET: Vozilo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vozilo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,SlikaVozila,Gorivo,Klasa,Mjenjac,Lokacija,MaksimalanBrojPutnika,CijenaPoDanu,DatumTehnickogPregleda,BrojRegistacijskihTablica,Klima,SistemBezKljuca,AluminijskeFelge,SklopiviRetrovizori,BoardComputer,MP3Interfejs")] Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vozilo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vozilo);
        }

        [Authorize(Roles = "Administrator")]
        // GET: Vozilo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vozilo = await _context.Vozilo.FindAsync(id);
            if (vozilo == null)
            {
                return NotFound();
            }
            return View(vozilo);
        }

        // POST: Vozilo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,SlikaVozila,Gorivo,Klasa,Mjenjac,Lokacija,MaksimalanBrojPutnika,CijenaPoDanu,DatumTehnickogPregleda,BrojRegistacijskihTablica,Klima,SistemBezKljuca,AluminijskeFelge,SklopiviRetrovizori,BoardComputer,MP3Interfejs")] Vozilo vozilo)
        {
            if (id != vozilo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vozilo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoziloExists(vozilo.Id))
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
            return View(vozilo);
        }

        [Authorize(Roles = "Administrator")]
        // GET: Vozilo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vozilo = await _context.Vozilo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vozilo == null)
            {
                return NotFound();
            }

            return View(vozilo);
        }

        // POST: Vozilo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vozilo = await _context.Vozilo.FindAsync(id);
            _context.Vozilo.Remove(vozilo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoziloExists(int id)
        {
            return _context.Vozilo.Any(e => e.Id == id);
        }
    }
}
