using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;
using School.Models.Dtos;
using School.Models.ViewModels;

namespace School.Controllers
{
    [Authorize(Roles =RoleNames.Teacher)]
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
        public async Task<IActionResult> ExamUploadScore()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new ScoreRecordViewModel(_context);
            model.Class = Class;
            return View(model);
        }
        public async Task<IActionResult> TestUploadScore()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new ScoreRecordViewModel(_context);
            model.Class = Class;
            return View(model);
        }

        public async Task<IActionResult> ExamScore()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new AllDepartmentsExams();
            model.ScienceExams = new List<StudentExams>();
            model.CommercialExams = new List<StudentExams>();
            model.ArtExams = new List<StudentExams>();
            int ScienceId = _context.Departments.Single(d => d.Name == "Science").Id;
            int CommercialId = _context.Departments.Single(d => d.Name == "Commercial").Id;
            int ArtId = _context.Departments.Single(d => d.Name == "Art").Id;
            int CurrentTermId = _context.CurrentTerm.Id;
            var ScienceStudents = _context.Students.Where(s => s.DepartmentId == ScienceId && s.ClassId == Class.Id);
            var CommercialStudents = _context.Students.Where(s => s.DepartmentId == CommercialId && s.ClassId == Class.Id);
            var ArtStudents = _context.Students.Where(s => s.DepartmentId == ArtId && s.ClassId == Class.Id);
            foreach (var student in ScienceStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _context.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ScienceExams.Add(StudentExams);
            }
            foreach (var student in CommercialStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _context.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.CommercialExams.Add(StudentExams);
            }
            foreach (var student in ArtStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _context.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ArtExams.Add(StudentExams);
            }
            return View(model);
        }
        public async Task<IActionResult> TestScore()
        {
            var CurrentUser = (Teacher)await _userManager.GetUserAsync(User);
            var Class = _context.Classes.SingleOrDefault(c => c.Id == CurrentUser.ClassId);
            Class.Students = _context.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new AllDepartmentsTests();
            model.ScienceTests = new List<StudentTests>();
            model.CommercialTests = new List<StudentTests>();
            model.ArtTests = new List<StudentTests>();
            int ScienceId = _context.Departments.Single(d => d.Name == "Science").Id;
            int CommercialId = _context.Departments.Single(d => d.Name == "Commercial").Id;
            int ArtId = _context.Departments.Single(d => d.Name == "Art").Id;
            int CurrentTermId = _context.CurrentTerm.Id;
            var ScienceStudents = _context.Students.Where(s => s.DepartmentId == ScienceId && s.ClassId == Class.Id);
            var CommercialStudents = _context.Students.Where(s => s.DepartmentId == CommercialId && s.ClassId == Class.Id);
            var ArtStudents = _context.Students.Where(s => s.DepartmentId == ArtId && s.ClassId == Class.Id);
            foreach (var student in ScienceStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Test = _context.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Test.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ScienceTests.Add(StudentTests);
            }
            foreach (var student in CommercialStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Tests = _context.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Tests.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.CommercialTests.Add(StudentTests);
            }
            foreach (var student in ArtStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Tests = _context.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Tests.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ArtTests.Add(StudentTests);
            }
            return View(model);
        }

    }
}
