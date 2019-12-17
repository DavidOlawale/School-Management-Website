using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherMessagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _manager;

        public TeacherMessagesController(ApplicationDbContext context, UserManager<ApplicationUser> manager)
        {
            _context = context;
            _manager = manager;
        }

        [HttpGet]
        public async Task<IEnumerable<Message>> GetRecievedMessagesAsync()
        {
            Guid UserId = (await _manager.GetUserAsync(User)).Id;
            return _context.Messages.Where(m => m.ReceiverId == UserId);
        }

        [HttpGet]
        public async Task<IEnumerable<Message>> GetSentMessagesAsync()
        {
            Guid UserId = (await _manager.GetUserAsync(User)).Id;
            return _context.Messages.Where(m => m.SenderId == UserId);
        }

        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        public async Task<ActionResult<Message>> PostParentMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSentMessagesAsync), new { }, message);
        }
    }
}
