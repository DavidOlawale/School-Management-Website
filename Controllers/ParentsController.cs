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
    [Authorize(Roles =RoleNames.Admin)]
    public class ParentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public UserManager<ApplicationUser> _usermanager { get; }
        public RoleManager<ApplicationRole> _roleManager { get; }

        private bool ParentExists(Guid id) => _context.Parents.Any(e => e.Id == id);
        public ParentsController(ApplicationDbContext context, UserManager<ApplicationUser> usermanager, RoleManager<ApplicationRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _usermanager = usermanager;
            _roleManager = roleManager;
            _env = env;
        }

        public IActionResult Index()
        {
            ViewData["isToast"] = false;
            return View(_context.Parents);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
                return NotFound();

            return View(parent);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel model, IFormFile Avatar)
        {
            if (!ModelState.IsValid)
                return View(model.Parent);
            await _usermanager.CreateAsync(model.Parent, model.Password);
            if (!(await _roleManager.RoleExistsAsync(RoleNames.Parent)))
                await _roleManager.CreateAsync(new ApplicationRole(RoleNames.Parent));

            await _usermanager.AddToRoleAsync(model.Parent, RoleNames.Parent);
            if (Avatar != null && Avatar.Length > 0)
            {
                string AvatarPath = Path.Combine(_env.WebRootPath, "Images", "Avatars");
                // if user has a profile photo before
                if (model.Parent.ProfilePhotoExtension != null)
                {
                    string file = Path.Combine(AvatarPath, model.Parent.Id + "." + model.Parent.ProfilePhotoExtension);
                    System.IO.File.Delete(file);
                }
                string ImageExtension = Avatar.FileName.Split('.').Last();
                Directory.CreateDirectory(AvatarPath);
                var stream = new FileStream(Path.Combine(AvatarPath, model.Parent.Id + "." + ImageExtension), FileMode.CreateNew, FileAccess.ReadWrite);
                await Avatar.CopyToAsync(stream);
                stream.Close();
                var ParentInDb = _context.Parents.Single(p => p.UserName == model.Parent.UserName);
                ParentInDb.ProfilePhotoExtension = ImageExtension;
                _context.Users.Update(ParentInDb);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
                return NotFound();
            return View(parent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id,  Parent parent)
        {
            if (id != parent.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentExists(parent.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parent);
        }

    }
}
