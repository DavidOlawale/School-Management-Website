﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataCore.Data;
using DataCore.Models;

namespace DataCore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin, Parent")]
    public class MessagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _manager;

        public MessagesController(ApplicationDbContext context, UserManager<ApplicationUser> manager)
        {
            _context = context;
            _manager = manager;
        }

        [HttpGet("Received")]
        public async Task<IEnumerable<Message>> Received()
        {
            Guid UserId = (await _manager.GetUserAsync(User)).Id;
            IQueryable<Message> messages = null;
            if (User.IsInRole(RoleNames.Admin))
                messages = _context.Messages.Where(m => m.ToAdmin).Include(m => m.Sender);
            else
                messages = _context.Messages.Where(m => m.ToAllParents || m.ReceiverId == UserId).Include(m => m.Sender);
            return messages;
        }

        [HttpGet("Sent")]
        public async Task<IEnumerable<Message>> Sent()
        {
            Guid UserId = (await _manager.GetUserAsync(User)).Id;
            return _context.Messages.Where(m => m.SenderId == UserId);
        }

        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            if (User.IsInRole(RoleNames.Admin))
            {
                if (message.ToAllParents)
                {
                    message.ReceiverId = null;
                }
                else
                {
                    if (message.ReceiverId == null)
                    {
                        return BadRequest("ReceiverId expected");
                    }
                }
            }
            else // User is a parent
            {
                message.ToAdmin = true;
            }
            message.SentDate = DateTime.Now;
            message.SenderId = (await _manager.GetUserAsync(User)).Id;
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Sent", new { id = message.Id }, message);
        }

    }
}
