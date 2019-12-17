using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers
{
    public class ParentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private bool ParentExists(Guid id) => _context.Parents.Any(e => e.Id == id);
        public ParentsController(ApplicationDbContext context) => _context = context;

        public IActionResult Index()
        {
            ViewData["isToast"] = false;
            return View(_context.Parents);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
                return NotFound();

            return View(parent);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Parent parent)
        {
            if (!ModelState.IsValid)
                return View(parent);
            parent.Id = Guid.NewGuid();
            _context.Add(parent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
                return NotFound();
            return View(parent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id,  Parent parent)
        {
            if (id != parent.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentExists(parent.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parent);
        }

        // GET: Parents/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var parent = await _context.Parents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parent == null)
                return NotFound();
            return View(parent);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var parent = await _context.Parents.FindAsync(id);
            _context.Parents.Remove(parent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
