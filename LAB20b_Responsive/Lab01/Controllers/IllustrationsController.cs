﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab01.Data;
using Lab01.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab01.Controllers
{
    [Authorize("IsAdmin")]
    public class IllustrationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IllustrationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Illustrations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Illustrations.ToListAsync());
        }

        // GET: Illustrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustration = await _context.Illustrations
                .FirstOrDefaultAsync(m => m.IllustrationId == id);
            if (illustration == null)
            {
                return NotFound();
            }

            return View(illustration);
        }

        // GET: Illustrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Illustrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Year,Month,Name,Description,ThumbNailId,ImageUrl")] Illustration illustration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(illustration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(illustration);
        }

        // GET: Illustrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustration = await _context.Illustrations.FindAsync(id);
            if (illustration == null)
            {
                return NotFound();
            }
            return View(illustration);
        }

        // POST: Illustrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Year,Month,Name,Description,ImageUrl")] Illustration illustration)
        {
            if (id != illustration.IllustrationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(illustration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IllustrationExists(illustration.IllustrationId))
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
            return View(illustration);
        }

        // GET: Illustrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustration = await _context.Illustrations
                .FirstOrDefaultAsync(m => m.IllustrationId == id);
            if (illustration == null)
            {
                return NotFound();
            }

            return View(illustration);
        }

        // POST: Illustrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var illustration = await _context.Illustrations.FindAsync(id);
            _context.Illustrations.Remove(illustration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IllustrationExists(int id)
        {
            return _context.Illustrations.Any(e => e.IllustrationId == id);
        }
    }
}
