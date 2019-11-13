using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers
{

    [Authorize(Roles = "Admin")]
    public class TeachersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public TeachersController(UserManager<ApplicationUser> manager, ApplicationDbContext context, RoleManager<ApplicationRole> rolemanager)
        {
            _userManager = manager;
            _context = context;
            _roleManager = rolemanager;
        }
        public ActionResult Index()
        {
            var teachers = _context.Teachers;
            ViewData["isToast"] = false;
            return View(teachers);
        }

        public IActionResult Details(string id)
        {
            var teacher = _context.Teachers.Find(id);
            return View(teacher);
        }

        public ActionResult Create()
        {
            ViewBag.ClassId = new SelectList(_context.Classes, "Id", "Name");
            var model = new CreateUserViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateUserViewModel model)
        {
            ViewData["isToast"] = true;
            var teachers = _context.Teachers;

            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }
            var createresult = await _userManager.CreateAsync(model.Teacher, model.Password);
            if (!createresult.Succeeded)
            {
                ViewData["toastTitle"] = "Error";
                ViewData["toastText"] = "Error ecountered while registering Teacher";
                ViewData["toastType"] = "error";
                return View("Index", teachers);
            }
            //create teacher role if it doesn't exist
            if (_context.Roles.SingleOrDefault(role => role.Name == RoleNames.Teacher) == null)
            {
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Teacher));
            }
            var addtoroleresult = await _userManager.AddToRoleAsync(model.Teacher, RoleNames.Teacher);
            if (!addtoroleresult.Succeeded)
            {
                ViewData["toastTitle"] = "Error";
                ViewData["toastText"] = "Error ecountered while registering Teacher";
                ViewData["toastType"] = "error";
                await _userManager.DeleteAsync(model.Teacher);
                return View("Index", teachers);
            }
            ViewData["toastTitle"] = "Registration succesful";
            ViewData["toastText"] = model.Teacher.FirstName + " " + model.Teacher.MiddleName + " successfully registred";
            ViewData["toastType"] = "success";
            return View("Index", teachers);
        }

        public ActionResult Edit(string id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Teacher teacher)
        {
            var teacherInDb = _context.Teachers.Find(teacher.Id);
            teacherInDb.FirstName = teacher.FirstName;
            teacherInDb.MiddleName = teacher.MiddleName;
            teacherInDb.LastName = teacher.LastName;
            teacherInDb.Email = teacher.Email;
            teacherInDb.DOB = teacher.DOB;
            teacherInDb.Address = teacher.Address;
            teacherInDb.ClassId = teacher.ClassId;
            teacherInDb.PhoneNumber = teacher.PhoneNumber;
            teacherInDb.EmploymentDate = teacher.EmploymentDate;

            await _userManager.UpdateAsync(teacherInDb);
            var notification = new Notification()
            {
                Title = "Update successfull",
                Text = teacher.FirstName + " " + teacher.MiddleName + " updated successfully",
                Type = "success"
            };
            return RedirectToAction("Index", notification);
        }

        public ActionResult Delete(string id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}