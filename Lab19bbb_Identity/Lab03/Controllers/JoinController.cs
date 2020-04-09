using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab03.Data;
using Lab03.Models;
using Lab03.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace Lab03.Controllers
{
    public class JoinController : Controller
    {

        private readonly ApplicationDbContext _context;

        public JoinController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Join
        [Authorize("IsAdmin")] // Specifies that to axcess this meathod you need to be authoriezed with the claim "IsAdmin"
        public async Task<IActionResult> Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(await _context.JoinApplications.ToListAsync());
            }
            return View(await _context.JoinApplications.ToListAsync());
        }

        // GET: Join/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinApplication = await _context.JoinApplications
                .FirstOrDefaultAsync(m => m.JoinApplicationId == id);
            if (joinApplication == null)
            {
                return NotFound();
            }

            return View(joinApplication);
        }

        // GET: Join/Create
        public IActionResult Create()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        // POST: Join/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Experience")] JoinApplication joinApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joinApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joinApplication);
        }

        // GET: Join/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinApplication = await _context.JoinApplications.FindAsync(id);
            if (joinApplication == null)
            {
                return NotFound();
            }
            return View(joinApplication);
        }

        // POST: Join/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("JoinApplicationId,Name,Email,Experience")] JoinApplication joinApplication)
        {
            if (id != joinApplication.JoinApplicationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joinApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoinApplicationExists(joinApplication.JoinApplicationId))
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
            return View(joinApplication);
        }

        // GET: Join/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joinApplication = await _context.JoinApplications
                .FirstOrDefaultAsync(m => m.JoinApplicationId == id);
            if (joinApplication == null)
            {
                return NotFound();
            }

            return View(joinApplication);
        }

        // POST: Join/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var joinApplication = await _context.JoinApplications.FindAsync(id);
            _context.JoinApplications.Remove(joinApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoinApplicationExists(long id)
        {
            return _context.JoinApplications.Any(e => e.JoinApplicationId == id);
        }
    }
}
