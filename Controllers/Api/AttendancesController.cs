using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendancesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = RoleNames.Admin + "," + RoleNames.Parent)]
        [HttpGet("GetAttendances/{studentId}")]
        public async Task<ActionResult<IEnumerable<Attendance>>> GetAttendances(Guid studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null) return BadRequest("Student not found");
            return await _context.Attendances.Where(a => a.StudentId == studentId).ToListAsync();
        }

        [Authorize(Roles = RoleNames.Admin + "," + RoleNames.Parent)]
        [HttpGet("GetAttendanceToday/{studentId}")]
        public async Task<ActionResult<Attendance>> GetAttendanceToday(Guid studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null) return BadRequest("Student not found");
            var attendance = _context.Attendances.SingleOrDefault(a => a.StudentId == studentId && a.Date.Date == DateTime.Now.Date);
            return attendance;
        }

        [HttpPost("postattendance")]
        [Authorize(Roles = RoleNames.Teacher)]
        public async Task<ActionResult<Attendance>> PostAttendance([FromBody]Attendance attendance)
        {
            if (!_context.Students.Any(s => s.Id == attendance.StudentId)) return BadRequest("Student doesn't exist");
            if (_context.Attendances.SingleOrDefault(a => a.Date.Date == DateTime.Now.Date && a.StudentId == attendance.StudentId) != null)
                return BadRequest("Attendance already taken");
            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAttendances", new { studentId = attendance.Id }, attendance);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttendance(int id, [FromBody]Attendance attendance)
        {
            if (id != attendance.Id) return BadRequest();

            _context.Entry(attendance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Attendances.Any(e => e.Id == id)) return NotFound();
                else throw;
            }
            return NoContent();
        }
    }
}
