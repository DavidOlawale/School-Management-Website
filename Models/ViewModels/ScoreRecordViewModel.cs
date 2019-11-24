using School.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModels
{
    public class ScoreRecordViewModel
    {
        private readonly ApplicationDbContext _context;
        public ScoreRecordViewModel(ApplicationDbContext db)
        {
            _context = db;
        }
        public Class Class;
        public IEnumerable<Subject> ScienceSubjects { get
            {
                List<Subject> subjects = new List<Subject>();
                var DeptSubs = _context.departmentSubjects.Where(ds => ds.DepartmentId == _context.Departments.Single(d => d.Name == "Science").Id);
                foreach (var DeptSub in DeptSubs)
                {
                    subjects.Add(_context.Subjects.Single(s => s.Id == DeptSub.SubjectId));
                }
                return subjects;

            } }
        public IEnumerable<Subject> CommercialSubjects { get
            {
                List<Subject> subjects = new List<Subject>();
                var DeptSubs = _context.departmentSubjects.Where(ds => ds.DepartmentId == _context.Departments.Single(d => d.Name == "Commercial").Id);
                foreach (var DeptSub in DeptSubs)
                {
                    subjects.Add(_context.Subjects.Single(s => s.Id == DeptSub.SubjectId));
                }
                return subjects;
            } }
        public IEnumerable<Subject> ArtSubjects { get
            {
                List<Subject> subjects = new List<Subject>();
                var DeptSubs = _context.departmentSubjects.Where(ds => ds.DepartmentId == _context.Departments.Single(d => d.Name == "Art").Id);
                foreach (var DeptSub in DeptSubs)
                {
                    subjects.Add(_context.Subjects.Single(s => s.Id == DeptSub.SubjectId));
                }
                return subjects;
            } }


        public IEnumerable<Student> ScienceStudents { get => Class.Students.Where(s => s.DepartmentId == _context.Departments.Single(d => d.Name == "Science").Id); }
        public IEnumerable<Student> CommercialStudents { get => Class.Students.Where(s => s.DepartmentId == _context.Departments.Single(d => d.Name == "Commercial").Id); }
        public IEnumerable<Student> ArtStudents { get => Class.Students.Where(s => s.DepartmentId == _context.Departments.Single(d => d.Name == "Art").Id); }
    }
}
