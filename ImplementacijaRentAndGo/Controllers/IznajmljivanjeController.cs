using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImplementacijaRentAndGo.Data;
using ImplementacijaRentAndGo.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ImplementacijaRentAndGo.Controllers
{
    public class IznajmljivanjeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IznajmljivanjeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Iznajmljivanje
        public async Task<IActionResult> Index()
        {
            return View(await _context.Iznajmljivanje.ToListAsync());
        }

        // GET: Iznajmljivanje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznajmljivanje = await _context.Iznajmljivanje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (iznajmljivanje == null)
            {
                return NotFound();
            }

            return View(iznajmljivanje);
        }
        [Authorize]
        // GET: Iznajmljivanje/Create
        public async Task<IActionResult> Create(int? id)
        {
            var vozilo = await _context.Vozilo.FindAsync(id);
            Console.WriteLine("Vozilo je " + vozilo.Naziv + " " + vozilo.Lokacija);
            IznajmljivanjeVozac mymodel = new IznajmljivanjeVozac();
            mymodel.Vozac = await _context.Vozac.ToListAsync();

            ViewBag.Message = vozilo;
            return View(mymodel);
        }

        // POST: Iznajmljivanje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Iznajmljivanje,Vozac")] IznajmljivanjeVozac iznajmljivanjeVozac)
        {
            //[Bind("ID,IDKlijenta,IDVozila,IDVozaca,IDAdmin,Cijena,Lokacija,Stanje,Komentar,Popust,NacinPlacanja,DatumPreuzmanja,DatumVracanja")] Iznajmljivanje iznajmljivanje
            Iznajmljivanje iznajmljivanje = iznajmljivanjeVozac.Iznajmljivanje;
            iznajmljivanje.Stanje = Stanje.CEKA;
            Vozac vozac = (Vozac)iznajmljivanjeVozac.Vozac;
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            iznajmljivanje.IDKlijenta = int.Parse(currentUserID);
            if(iznajmljivanje.IDVozaca == 0) { 
                iznajmljivanje.IDVozaca = int.Parse(currentUserID);
            }
            if (ModelState.IsValid)
            {
                _context.Add(iznajmljivanje);
                await _context.SaveChangesAsync();
                var vozilo = await _context.Vozilo.FindAsync(iznajmljivanje.IDVozila);
                vozilo.Lokacija = Lokacija.NEDOSTUPNO;
                try
                {
                    _context.Update(vozilo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            //vozilo nedostupno
            return View(iznajmljivanje);
        }

        // GET: Iznajmljivanje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznajmljivanje = await _context.Iznajmljivanje.FindAsync(id);
            if (iznajmljivanje == null)
            {
                return NotFound();
            }
            return View(iznajmljivanje);
        }

        // POST: Iznajmljivanje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDKlijenta,IDVozila,IDVozaca,IDAdmin,Cijena,Lokacija,Stanje,Komentar,Popust,NacinPlacanja,DatumPreuzmanja,DatumVracanja")] Iznajmljivanje iznajmljivanje)
        {
            if (id != iznajmljivanje.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iznajmljivanje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IznajmljivanjeExists(iznajmljivanje.ID))
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
            return View(iznajmljivanje);
        }

        // GET: Iznajmljivanje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznajmljivanje = await _context.Iznajmljivanje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (iznajmljivanje == null)
            {
                return NotFound();
            }

            return View(iznajmljivanje);
        }

        // POST: Iznajmljivanje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iznajmljivanje = await _context.Iznajmljivanje.FindAsync(id);
            _context.Iznajmljivanje.Remove(iznajmljivanje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IznajmljivanjeExists(int id)
        {
            return _context.Iznajmljivanje.Any(e => e.ID == id);
        }
    }
}
