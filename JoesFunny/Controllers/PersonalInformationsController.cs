using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JoesFunny.Data;
using JoesFunny.Models;

namespace JoesFunny.Controllers
{
    public class PersonalInformationsController : Controller
    {
        private readonly JoesFunnyContext _context;

        public PersonalInformationsController(JoesFunnyContext context)
        {
            _context = context;
        }

        // GET: PersonalInformations
        // GET: Movies
        public async Task<IActionResult> Index(string address, string searchString)
        {
            if (_context.PersonalInformation == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> addressQuery = from m in _context.PersonalInformation
                                            orderby m.address
                                            select m.address;
            var addresses = from m in _context.PersonalInformation
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                addresses = addresses.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(address))
            {
                addresses = addresses.Where(x => x.address == address);
            }

            var PersonalAddressVM = new PersonalAddressViewModel
            {
                Addresses = new SelectList(await addresses.Distinct().ToListAsync()),
                Address = await address.ToListAsync()
            };

            return View(PersonalAddressVM);
        }

        // GET: PersonalInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PersonalInformation == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            return View(personalInformation);
        }

        // GET: PersonalInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DateOfBirth,SocialSecurityNumber,address")] PersonalInformation personalInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalInformation);
        }

        // GET: PersonalInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PersonalInformation == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInformation.FindAsync(id);
            if (personalInformation == null)
            {
                return NotFound();
            }
            return View(personalInformation);
        }

        // POST: PersonalInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DateOfBirth,SocialSecurityNumber,address")] PersonalInformation personalInformation)
        {
            if (id != personalInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalInformationExists(personalInformation.Id))
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
            return View(personalInformation);
        }

        // GET: PersonalInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PersonalInformation == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            return View(personalInformation);
        }

        // POST: PersonalInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PersonalInformation == null)
            {
                return Problem("Entity set 'JoesFunnyContext.PersonalInformation'  is null.");
            }
            var personalInformation = await _context.PersonalInformation.FindAsync(id);
            if (personalInformation != null)
            {
                _context.PersonalInformation.Remove(personalInformation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalInformationExists(int id)
        {
          return (_context.PersonalInformation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
