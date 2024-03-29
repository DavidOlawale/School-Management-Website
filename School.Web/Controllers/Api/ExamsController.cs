﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataCore.Data;
using DataCore.Models;
using DataCore.Models.Dtos;

namespace DataCore.Controllers.Api
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Teacher")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Exams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exam>>> GetExams()
        {
            return await _context.Exams.ToListAsync();
        }

        // GET: api/Exams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExam(int id)
        {
            var exam = await _context.Exams.FindAsync(id);

            if (exam == null)
            {
                return NotFound();
            }

            return exam;
        }

        // PUT: api/Exams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExam(int id, Exam exam)
        {
            if (id != exam.DepartmentSubjectDepartmentId)
            {
                return BadRequest();
            }

            _context.Entry(exam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("postexam")]
        [Authorize(Roles = RoleNames.Parent)]
        public async Task<ActionResult<Exam>> PostExam([FromBody] ExamRecordModel model)
        {
            int DepartmentId = _context.Departments.Single(d => d.Name == model.DepartmentName).Id;
            int termId = _context.CurrentTerm.Id;
            foreach (var examdto in model.Exams)
            {
                var exam = new Exam();
                exam.DepartmentSubjectDepartmentId = DepartmentId;
                exam.DepartmentSubjectSubjectId = examdto.DepartmentSubjectSubjecttId;
                exam.StudentId = examdto.StudentId;
                exam.Score = examdto.Score;
                exam.TermId = termId;
                _context.Exams.Add(exam);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExams", new { });
        }

        // DELETE: api/Exams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Exam>> DeleteExam(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }

            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();

            return exam;
        }

        private bool ExamExists(int id)
        {
            return _context.Exams.Any(e => e.DepartmentSubjectDepartmentId == id);
        }
    }
}
