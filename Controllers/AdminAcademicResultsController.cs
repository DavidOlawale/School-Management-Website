using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;
using School.Models.Dtos;
using School.Models.ViewModels;

namespace School.Controllers
{
    [Authorize(Roles =RoleNames.Admin)]
    public class AdminAcademicResultsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminAcademicResultsController(ApplicationDbContext dbContext)
        {
            this._db = dbContext;
        }
        public IActionResult Exams()
        {
            var classes = _db.Classes;
            var Model = new List<ClassDetailsViewModel>();
            foreach (var Class in classes)
            {
                var teacher = _db.Teachers.FirstOrDefault(t => t.ClassId == Class.Id);
                Model.Add(new ClassDetailsViewModel(Class, teacher));
            }
            return View(Model);
        }
        public IActionResult Tests()
        {
            var classes = _db.Classes;
            var Model = new List<ClassDetailsViewModel>();
            foreach (var Class in classes)
            {
                var teacher = _db.Teachers.FirstOrDefault(t => t.ClassId == Class.Id);
                Model.Add(new ClassDetailsViewModel(Class, teacher));
            }
            return View(Model);
        }
        public IActionResult ClassExams(int Id)
        {
            var Class = _db.Classes.Find(Id);
            Class.Students = _db.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new AllDepartmentsExams();
            model.ScienceExams = new List<StudentExams>();
            model.CommercialExams = new List<StudentExams>();
            model.ArtExams = new List<StudentExams>();
            int ScienceId = _db.Departments.Single(d => d.Name == "Science").Id;
            int CommercialId = _db.Departments.Single(d => d.Name == "Commercial").Id;
            int ArtId = _db.Departments.Single(d => d.Name == "Art").Id;
            int CurrentTermId = _db.CurrentTerm.Id;
            var ScienceStudents = _db.Students.Where(s => s.DepartmentId == ScienceId && s.ClassId == Class.Id);
            var CommercialStudents = _db.Students.Where(s => s.DepartmentId == CommercialId && s.ClassId == Class.Id);
            var ArtStudents = _db.Students.Where(s => s.DepartmentId == ArtId && s.ClassId == Class.Id);
            foreach (var student in ScienceStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _db.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ScienceExams.Add(StudentExams);
            }
            foreach (var student in CommercialStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _db.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.CommercialExams.Add(StudentExams);
            }
            foreach (var student in ArtStudents)
            {
                var StudentExams = new StudentExams();
                StudentExams.StudentName = student.FullName;
                var Exams = _db.Exams.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentExams.Exams = Exams.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ArtExams.Add(StudentExams);
            }
            return View(model);
        }

        public IActionResult ClassTests(int Id)
        {
            var Class = _db.Classes.Find(Id);
            Class.Students = _db.Students.Where(s => s.ClassId == Class.Id).ToList();
            var model = new AllDepartmentsTests();
            model.ScienceTests = new List<StudentTests>();
            model.CommercialTests = new List<StudentTests>();
            model.ArtTests = new List<StudentTests>();
            int ScienceId = _db.Departments.Single(d => d.Name == "Science").Id;
            int CommercialId = _db.Departments.Single(d => d.Name == "Commercial").Id;
            int ArtId = _db.Departments.Single(d => d.Name == "Art").Id;
            int CurrentTermId = _db.CurrentTerm.Id;
            var ScienceStudents = _db.Students.Where(s => s.DepartmentId == ScienceId && s.ClassId == Class.Id);
            var CommercialStudents = _db.Students.Where(s => s.DepartmentId == CommercialId && s.ClassId == Class.Id);
            var ArtStudents = _db.Students.Where(s => s.DepartmentId == ArtId && s.ClassId == Class.Id);
            foreach (var student in ScienceStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Test = _db.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Test.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ScienceTests.Add(StudentTests);
            }
            foreach (var student in CommercialStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Tests = _db.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Tests.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.CommercialTests.Add(StudentTests);
            }
            foreach (var student in ArtStudents)
            {
                var StudentTests = new StudentTests();
                StudentTests.StudentName = student.FullName;
                var Tests = _db.Tests.Where(e => e.StudentId == student.Id && e.TermId == CurrentTermId);
                StudentTests.Tests = Tests.Include(e => e.DepartmentSubject).ThenInclude(ds => ds.Subject).ToList();
                model.ArtTests.Add(StudentTests);
            }
            return View(model);
        }
    }
}