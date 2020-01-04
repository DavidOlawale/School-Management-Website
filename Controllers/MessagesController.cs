using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers
{
    [Authorize(Roles ="Admin,Parent")]
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult New()
        {
            ViewBag.Parents = new SelectList(_context.Parents, nameof(Parent.Id), nameof(Parent.FullName), "Select parent");
            if (User.IsInRole(RoleNames.Admin))
                return View("AdminNew");
            else
                return View("ParentNew");
        }
        public async Task<IActionResult> Received(int Id)
        {
            var message = await _context.Messages.SingleOrDefaultAsync(m => m.Id == Id);
            if (message == null)
                return NotFound();
            message.Sender = await _context.Users.FindAsync(message.SenderId);
            return View(message);
        }
    }
}
