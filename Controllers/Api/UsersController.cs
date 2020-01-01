using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Data;
using School.Models;

namespace School.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpDelete("DeleteUser/{id}")]
        public async Task<ApplicationUser> deleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}