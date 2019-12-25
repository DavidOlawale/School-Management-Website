using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IHostingEnvironment _env;

        public TeachersController(UserManager<ApplicationUser> manager, ApplicationDbContext context, RoleManager<ApplicationRole> rolemanager, IHostingEnvironment env)
        {
            _userManager = manager;
            _context = context;
            _roleManager = rolemanager;
            _env = env;
        }
        public ActionResult Index()
        {
            var teachers = _context.Teachers;
            ViewData["isToast"] = false;
            return View(teachers);
        }

        public IActionResult Details(Guid id)
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
        public async Task<ActionResult> Create(CreateUserViewModel model, IFormFile Avatar)
        {
            if (!ModelState.IsValid)
                return View("Create", model);
            ViewData["isToast"] = true;
            var createresult = await _userManager.CreateAsync(model.Teacher, model.Password);
            var teachers = _context.Teachers;
            var notification = new Notification();
            if (!createresult.Succeeded)
            {
                notification.Text = "Error";
                notification.Text = "Error ecountered while registering teacher";
                notification.Type = "error";
                return RedirectToAction("Index", teachers);
            }
            //create teacher role if it doesn't exist
            if (_context.Roles.SingleOrDefault(role => role.Name == RoleNames.Teacher) == null)
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Teacher));
            
            var addtoroleresult = await _userManager.AddToRoleAsync(model.Teacher, RoleNames.Teacher);
            if (!addtoroleresult.Succeeded)
            {
                notification.Title = "Error";
                notification.Text = "Error ecountered while registering teacher";
                notification.Type = "error";
                await _userManager.DeleteAsync(model.Teacher);
                return RedirectToAction("Index", teachers);
            }
            if (Avatar != null)
            {
                string ImageExtension = Avatar.FileName.Split('.').Last();
                model.Teacher.ProfilePhotoExtension = ImageExtension;
                string AvatarPath = Path.Combine(_env.WebRootPath, "Images", "Avatars");
                Directory.CreateDirectory(AvatarPath);
                var stream = new FileStream(Path.Combine(AvatarPath, model.Teacher.Id.ToString() + '.' + ImageExtension), FileMode.CreateNew, FileAccess.ReadWrite);
                await Avatar.CopyToAsync(stream);
                stream.Close();
                _context.Users.Update(model.Teacher);
                await _context.SaveChangesAsync();
            }
            
            notification.Title = "Registration succesful";
            notification.Text = model.Teacher.FirstName + " " + model.Teacher.MiddleName + " successfully registered";
            notification.Type = "success";
            return RedirectToActionPermanent("Index", notification);
        }

        public ActionResult Edit(Guid id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Teacher teacher, IFormFile Avatar)
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
            if (Avatar != null && Avatar.Length > 0)
            {
                string AvatarPath = Path.Combine(_env.WebRootPath, "Images", "Avatars");
                if (teacherInDb.ProfilePhotoExtension != null)
                {
                    string file = Path.Combine(AvatarPath, teacher.Id + "." + teacherInDb.ProfilePhotoExtension);
                    System.IO.File.Delete(file);
                }
                string ImageExtension = Avatar.FileName.Split('.').Last();
                teacher.ProfilePhotoExtension = ImageExtension;
                Directory.CreateDirectory(AvatarPath);
                var stream = new FileStream(Path.Combine(AvatarPath, teacher.Id + "." + ImageExtension), FileMode.CreateNew, FileAccess.ReadWrite);
                await Avatar.CopyToAsync(stream);
                stream.Close();
                _context.Users.Update(teacherInDb);
                await _context.SaveChangesAsync();
            }
            var notification = new Notification()
            {
                Title = "Update successfull",
                Text = teacher.FirstName + " " + teacher.MiddleName + " updated successfully",
                Type = "success"
            };
            return RedirectToAction("Index", notification);
        }

        public ActionResult Delete(Guid id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            return View();
        }
    }
}