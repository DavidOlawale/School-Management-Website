using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data
{
    /// <summary>
    /// This class is for seeding data required for the app
    /// </summary>
    public static class DbInitializer
    {

        public static async Task InitializeAsync(ApplicationDbContext _db, UserManager<ApplicationUser> _userManager, RoleManager<ApplicationRole> _roleManager)
        {
            _db.Database.Migrate();

            //seed departments
            if (!_db.Departments.Any())
            {
                var Science = new Department("Science");
                var Commercial = new Department("Commercial");
                var Art = new Department("Art");
                _db.Departments.Add(Science);
                _db.Departments.Add(Commercial);
                _db.Departments.Add(Art);
                _db.SaveChanges();
            }


            //seed roles
            if (!_db.Roles.Any())
            {
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Admin));
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Teacher));
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Student));
            }

            //seed classes
            if (!_db.Classes.Any())
            {
                var classes = new Class[6]
                {
                    new Class("JSS 1"),
                    new Class("JSS 2"),
                    new Class("JSS 3"),
                    new Class("SSS 1"),
                    new Class("SSS 2"),
                    new Class("SSS 3")
                };
                foreach (var Class in classes)
                {
                    _db.Classes.Add(Class);
                }
                _db.SaveChanges();
            }

            //seed users
            if (!_db.Users.Any())
            {
                var student = new Student()
                {
                    FirstName = "zannu",
                    MiddleName = "Emmanuel",
                    LastName = "Femi",
                    Address = "No 10 whatever str",
                    AdmissionDate = DateTime.Now,
                    Email = "zannu@gmail.com",
                    DOB = new DateTime(1999, 9, 12),
                    UserName = "emmanuel",
                    PhoneNumber = "08012345678",
                    ClassId = _db.Classes.Single(c => c.Name == "SSS 2").Id,
                    DepartmentId = _db.Departments.Single(d => d.Name == "Science").Id
                };
                var admin = new Admin()
                {
                    FirstName = "Olaniran",
                    MiddleName = "Olawale",
                    LastName = "David",
                    Address = "No 10 ajibade str",
                    Email = "olawale@gmail.com",
                    UserName = "olawale",
                    PhoneNumber = "08012345678"
                };
                var teacher = new Teacher()
                {
                    FirstName = "Babatunde",
                    MiddleName = "tunde",
                    LastName = "ola",
                    Address = "No 10 awolowo way ikeja",
                    Email = "babatunde@gmail.com",
                    UserName = "babatunde",
                    PhoneNumber = "08012233456",
                    DOB = new DateTime(1990, 8, 10),
                    EmploymentDate = DateTime.Now,
                    ClassId = _db.Classes.Single(c => c.Name == "SSS 2").Id
                };
                await _userManager.CreateAsync(admin, "123abc");
                await _userManager.CreateAsync(teacher, "123abc");
                await _userManager.CreateAsync(student, "123abc");

                await _userManager.AddToRoleAsync(admin, RoleNames.Admin);
                await _userManager.AddToRoleAsync(teacher, RoleNames.Teacher);
                await _userManager.AddToRoleAsync(student, RoleNames.Student);

                //Add Class teacher
                teacher.ClassId = 5;
                _db.Update(teacher);
            }

            //seed subjects
            if (!_db.Subjects.Any())
            {
                var Mathematics = new Subject("Mathematics"); //0
                var English = new Subject("English");
                var Chemistry = new Subject("Chemistry");
                var FutherMaths = new Subject("Futher maths");  //3
                var Physics = new Subject("Physics");
                var Biology = new Subject("Biology");
                var Economics = new Subject("Economics"); //6
                var Account = new Subject("Account");  //7
                var Commerce = new Subject("Commerce");  //8
                var Literature = new Subject("Literature");  //9
                var Computer = new Subject("Computer");
                var Geography = new Subject("Geography");
                var BookKeeping = new Subject("Book keeping"); //12
                var Government = new Subject("Government"); //13
                Subject[] subjects = new Subject[]
                {
                Mathematics, English, Chemistry, FutherMaths, Physics, Biology, Economics, Account, Commerce, Literature, Computer, Geography, BookKeeping, Government
                };

                foreach (var subject in subjects)
                {
                    _db.Subjects.Add(subject);
                }
                _db.SaveChanges();

                int ScienceId = _db.Departments.Single(d => d.Name == "Science").Id;
                int CommercialId = _db.Departments.Single(d => d.Name == "Commercial").Id;
                int ArtId = _db.Departments.Single(d => d.Name == "Art").Id;

                //seed Subject for each department
                DepartmentSubject[] departmentSubjects = new DepartmentSubject[]
                {
                new DepartmentSubject(ScienceId, Mathematics.Id),
                new DepartmentSubject(CommercialId, Mathematics.Id),
                new DepartmentSubject(ArtId, Mathematics.Id),
                new DepartmentSubject(ScienceId, English.Id),
                new DepartmentSubject(CommercialId, English.Id),
                new DepartmentSubject(ArtId, English.Id),
                new DepartmentSubject(ScienceId, Chemistry.Id),
                new DepartmentSubject(ScienceId, FutherMaths.Id),
                new DepartmentSubject(ScienceId, Physics.Id),
                new DepartmentSubject(ScienceId, Biology.Id),
                new DepartmentSubject(CommercialId, Biology.Id),
                new DepartmentSubject(ArtId, Biology.Id),
                new DepartmentSubject(ScienceId, Economics.Id),
                new DepartmentSubject(CommercialId, Economics.Id),
                new DepartmentSubject(ArtId, Economics.Id),
                new DepartmentSubject(CommercialId, Account.Id),
                new DepartmentSubject(ArtId, Literature.Id),
                new DepartmentSubject(ScienceId, Computer.Id),
                new DepartmentSubject(CommercialId, Computer.Id),
                new DepartmentSubject(ArtId, Computer.Id),
                new DepartmentSubject(ScienceId, Geography.Id),
                new DepartmentSubject(CommercialId, BookKeeping.Id),
                new DepartmentSubject(CommercialId, Government.Id),
                new DepartmentSubject(ArtId, Government.Id)
                };
                foreach (var deptSubj in departmentSubjects)
                {
                    _db.departmentSubjects.Add(deptSubj);
                }
                _db.SaveChanges();
            }
            

        }
    }
}
