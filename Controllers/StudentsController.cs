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
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IHostingEnvironment _env;

        public StudentsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _env = env;
        }

        public async Task<ActionResult> Index(Notification notification = null)
        {
            var students = _context.Students.Include(s => s.Class);
            if (notification.Text == null)
                ViewData["isToast"] = false;
            else
                ViewData["isToast"] = true;
            ViewData["toastTitle"] = notification.Title;
            ViewData["toastText"] = notification.Text;
            ViewData["toastType"] = notification.Type;
            return View(students);
        }

        public async Task<ActionResult> Details(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            student.Class = _context.Classes.Find(student.ClassId);
            return View(student);
        }

        public ActionResult Create()
        {
            ViewBag.ClassId = new SelectList(_context.Classes, "Id", "Name");
            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name");
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
            var createresult = await _userManager.CreateAsync(model.Student, model.Password);
            var students = _context.Students;
            var notification = new Notification();
            if (!createresult.Succeeded)
            {
                notification.Text = "Error";
                notification.Text = "Error ecountered while registering student";
                notification.Type = "error";
                return RedirectToAction("Index", students);
            }
            //create student role if it doesn't exist
            if (_context.Roles.SingleOrDefault(role => role.Name == RoleNames.Student) == null)
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Student));
            
            var addtoroleresult = await _userManager.AddToRoleAsync(model.Student, RoleNames.Student);
            if (!addtoroleresult.Succeeded)
            {
                notification.Title = "Error";
                notification.Text = "Error ecountered while registering student";
                notification.Type = "error";
                await _userManager.DeleteAsync(model.Student);
                return RedirectToAction("Index", students);
            }
            if (Avatar != null && Avatar.Length > 0)
            {
                string ImageExtension = Avatar.FileName.Split('.').Last();
                model.Student.ProfilePhotoExtension = ImageExtension;
                string AvatarPath = Path.Combine(_env.WebRootPath, "Images", "Avatars");
                Directory.CreateDirectory(AvatarPath);
                var stream = new FileStream(Path.Combine(AvatarPath, model.Student.Id.ToString() + '.' + ImageExtension), FileMode.CreateNew, FileAccess.ReadWrite);
                await Avatar.CopyToAsync(stream);
                stream.Close();
                _context.Users.Update(model.Student);
                await _context.SaveChangesAsync();
            }
            
            notification.Title = "Registration succesful";
            notification.Text = model.Student.FirstName + " " + model.Student.MiddleName + " successfully registered";
            notification.Type = "success";
            return RedirectToActionPermanent("Index", notification);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            ViewBag.ClassId = new SelectList(_context.Classes, "Id", "Name");
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Student student, IFormFile Avatar)
        {
            var StudentInDb = _context.Students.Find(student.Id);
            StudentInDb.FirstName = student.FirstName;
            StudentInDb.MiddleName = student.MiddleName;
            StudentInDb.LastName = student.LastName;
            StudentInDb.Email = student.Email;
            StudentInDb.DOB = student.DOB;
            StudentInDb.Address = student.Address;
            StudentInDb.ClassId = student.ClassId;
            StudentInDb.PhoneNumber = student.PhoneNumber;
            StudentInDb.AdmissionDate = student.AdmissionDate;
               
            await _userManager.UpdateAsync(StudentInDb);
            if (Avatar != null && Avatar.Length > 0)
            {
                string AvatarPath = Path.Combine(_env.WebRootPath, "Images", "Avatars");
                if (StudentInDb.ProfilePhotoExtension != null)
                {
                    string file = Path.Combine(AvatarPath, student.Id + "." + StudentInDb.ProfilePhotoExtension);
                    System.IO.File.Delete(file);
                }
                string ImageExtension = Avatar.FileName.Split('.').Last();
                student.ProfilePhotoExtension = ImageExtension;
                Directory.CreateDirectory(AvatarPath);
                var stream = new FileStream(Path.Combine(AvatarPath, student.Id + "." + ImageExtension), FileMode.CreateNew, FileAccess.ReadWrite);
                await Avatar.CopyToAsync(stream);
                stream.Close();
                _context.Users.Update(StudentInDb);
                await _context.SaveChangesAsync();
            }
            var notification = new Notification()
            {
                Title = "Update successfull",
                Text = student.FirstName + " " + student.MiddleName + " updated successfully",
                Type = "success"
            };
            return RedirectToAction("Index", notification);
        }
    }
}