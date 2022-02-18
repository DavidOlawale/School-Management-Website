using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataCore.Data;
using DataCore.Models;
using DataCore.Models.ViewModels;

namespace DataCore.Controllers
{
    [Authorize(Roles =RoleNames.Admin)]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ClassesController(ApplicationDbContext context, UserManager<ApplicationUser> manager)
        {
            _context = context;
            _userManager = manager;

        }

        public async Task<IActionResult> Index()
        {
            var Classes = _context.Classes;
            var Model = new List<ClassDetailsViewModel>();
            foreach (var Class in Classes)
            {
                var teacher = _context.Teachers.FirstOrDefault(t => t.ClassId == Class.Id);
                Model.Add(new ClassDetailsViewModel(Class, teacher));
            }
            return View(Model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var Class = await _context.Classes.FindAsync(id);
            if (Class == null)
                return NotFound();
            var Teacher = _context.Teachers.FirstOrDefault(t => t.ClassId == id);
            var model = new ClassDetailsViewModel(Class, Teacher);
            model.Students = _context.Students.Where(s => s.ClassId == id);
            var TodayAttendance = _context.Attendances.Where(a => a.Date.Date == DateTime.Now.Date);
            //finds students who don't have an attendance for today
            model.StudentsWithoutAttendance = model.Students.Where(s => !TodayAttendance.Any(a => a.StudentId == s.Id ));
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var Class = await _context.Classes.FindAsync(id);
            if (Class == null)
                return NotFound();
            return View(Class);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] AcademicClass Class)
        {
            if (id != Class.Id)
                return NotFound();

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
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Class);
        }

    }
}
