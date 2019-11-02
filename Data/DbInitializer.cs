using Microsoft.AspNetCore.Identity;
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
            if (!_db.Roles.Any())
            {
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Admin));
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Teacher));
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Student));
            }

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
                await _db.SaveChangesAsync();
            }

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
                    ClassId = _db.Classes.Single(c => c.Name == "SSS 2").Id
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
                    EmploymentDate = DateTime.Now
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

        }
    }
}
