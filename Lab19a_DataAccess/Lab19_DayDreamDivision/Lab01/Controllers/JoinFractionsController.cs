using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab01;

namespace Lab01.Controllers
{
    public class JoinFractionsController : Controller
    {
        private readonly AppDbContext _context;

        public JoinFractionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JoinFractions
        public async Task<IActionResult> Index()
        {
            return View(await _context.JoinFractions.ToListAsync());
        }

        // GET: JoinFractions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinFraction = await _context.JoinFractions
                .FirstOrDefaultAsync(m => m.FractionApplicationId == id);
            if (joinFraction == null)
            {
                return NotFound();
            }

            return View(joinFraction);
        }

        // GET: JoinFractions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JoinFractions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Experience")] JoinFraction joinFraction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joinFraction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joinFraction);
        }

        // GET: JoinFractions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinFraction = await _context.JoinFractions.FindAsync(id);
            if (joinFraction == null)
            {
                return NotFound();
            }
            return View(joinFraction);
        }

        // POST: JoinFractions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("FractionApplicationId,Name,Email,Experience")] JoinFraction joinFraction)
        {
            if (id != joinFraction.FractionApplicationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joinFraction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoinFractionExists(joinFraction.FractionApplicationId))
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
            return View(joinFraction);
        }

        // GET: JoinFractions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinFraction = await _context.JoinFractions
                .FirstOrDefaultAsync(m => m.FractionApplicationId == id);
            if (joinFraction == null)
            {
                return NotFound();
            }

            return View(joinFraction);
        }

        // POST: JoinFractions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var joinFraction = await _context.JoinFractions.FindAsync(id);
            _context.JoinFractions.Remove(joinFraction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoinFractionExists(long id)
        {
            return _context.JoinFractions.Any(e => e.FractionApplicationId == id);
        }
    }
}
