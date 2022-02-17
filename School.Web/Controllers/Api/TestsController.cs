using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataCore.Data;
using DataCore.Models;
using DataCore.Models.Dtos;

namespace DataCore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test>>> GetTests()
        {
            return await _context.Tests.ToListAsync();
        }

        // GET: api/Tests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test>> GetTest(int id)
        {
            var test = await _context.Tests.FindAsync(id);

            if (test == null)
            {
                return NotFound();
            }

            return test;
        }

        // PUT: api/Tests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest(int id, Test test)
        {
            if (id != test.DepartmentSubjectDepartmentId)
            {
                return BadRequest();
            }

            _context.Entry(test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestExists(id))
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

        [HttpPost("posttests")]
        public async Task<ActionResult<Test>> PostTest(TestRecordModel model)
        {
            int DepartmentId = _context.Departments.Single(d => d.Name == model.DepartmentName).Id;
            int termId = _context.CurrentTerm.Id;
            foreach (var testdto in model.Tests)
            {
                var Test = new Test();
                Test.DepartmentSubjectDepartmentId = DepartmentId;
                Test.DepartmentSubjectSubjectId = testdto.DepartmentSubjectSubjectId;
                Test.StudentId = testdto.StudentId;
                Test.Score = testdto.Score;
                Test.TermId = termId;
                _context.Tests.Add(Test);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTests", new { });
        }

        // DELETE: api/Tests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test>> DeleteTest(int id)
        {
            var test = await _context.Tests.FindAsync(id);
            if (test == null)
            {
                return NotFound();
            }
            _context.Tests.Remove(test);
            await _context.SaveChangesAsync();
            return test;
        }

        private bool TestExists(int id)
        {
            return _context.Tests.Any(e => e.DepartmentSubjectDepartmentId == id);
        }
    }
}
