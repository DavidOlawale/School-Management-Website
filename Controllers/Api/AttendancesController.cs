using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles ="Admin,Teacher")]
    public class AttendancesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Getstudentattendances/{studentId}")]
        public async Task<ActionResult<IEnumerable<Attendance>>> GetStudentAttendances(Guid studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null) return NotFound("Student not found");
            return await _context.Attendances.Where(a => a.StudentId == studentId).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Attendance>> PostAttendance([FromBody]Attendance attendance)
        {
            if (!_context.Students.Any(s => s.Id == attendance.StudentId)) return BadRequest("Student doesn't exist");
            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetStudentAttendances", new { id = attendance.Id }, attendance);
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
                if (!AttendanceExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        private bool AttendanceExists(int id)
        {
            return _context.Attendances.Any(e => e.Id == id);
        }
    }
}
