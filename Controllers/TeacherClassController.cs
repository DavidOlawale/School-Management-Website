using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;
using School.Models.ViewModels;

namespace School.Controllers
{
    public class TeacherClassController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> manager;
        private readonly UserManager<ApplicationUser> _userManager;

        public TeacherClassController(ApplicationDbContext context, UserManager<ApplicationUser> manager)
        {
            _context = context;
            this._userManager = manager;
        }
        public async Task<IActionResult> Details()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            var model = new ClassDetailsViewModel(Class, CurrentUser);
            model.Students = _context.Students.Where(s => s.ClassId == Class.Id);
            var TodayAttendance = _context.Attendances.Where(a => a.Date.Date == DateTime.Now.Date);
            //finds students who have an attendance for today
            model.StudentsWithoutAttendance = model.Students.Where(s => !TodayAttendance.Any(a => a.StudentId == s.Id));
            return View(model);
        }
        public async Task<IActionResult> Exam()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new ScoreRecordViewModel(_context);
            model.Class = Class;
            return View(model);
        }
        public async Task<IActionResult> Test()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new ScoreRecordViewModel(_context);
            model.Class = Class;
            return View(model);
        }

    }
}
