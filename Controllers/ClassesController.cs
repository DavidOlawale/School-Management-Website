using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;
using School.Models.ViewModels;

namespace School.Controllers
{
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var Classes = await _context.Classes.Include(c => c.Teacher).ToListAsync();
            return View(Classes);
        }

        public async Task<IActionResult> Details(int id)
        {
            var Class = await _context.Classes.FindAsync(id);
            Class.Teacher = await _context.Teachers.FindAsync(Class.TeacherId);
            if (Class == null)
            {
                return NotFound();
            }
            var model = new ClassDetailsViewModel(Class);
            model.Students = _context.Students.Where(s => s.ClassId == id);
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Class = await _context.Classes.FindAsync(id);
            if (Class == null)
            {
                return NotFound();
            }
            return View(Class);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Class Class)
        {
            if (id != Class.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Class);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Classes.Any(c => c.Id == id))
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
            return View(Class);
        }

    }
}
