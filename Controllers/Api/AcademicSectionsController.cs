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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = RoleNames.Admin)]
    public class AcademicSectionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AcademicSectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AcademicSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AcademicSection>>> GetAcademicSections()
        {
            return await _context.AcademicSections.ToListAsync();
        }

        // GET: api/AcademicSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AcademicSection>> GetAcademicSection(int id)
        {
            var academicSection = await _context.AcademicSections.FindAsync(id);

            if (academicSection == null)
            {
                return NotFound();
            }

            return academicSection;
        }

        // PUT: api/AcademicSections/5

        // POST: api/AcademicSections
        [HttpPost]
        public async Task<ActionResult<AcademicSection>> PostAcademicSection(AcademicSection academicSection)
        {

            if (_context.AcademicSections.Any())
            {
                var LastSection = _context.AcademicSections.Last();
                if (academicSection.BeginDate <= LastSection.EndDate)
                {
                    return BadRequest("Start date must be greater than the end date of the last Academic section");
                }
            }
            if (_context.Terms.Any())
            {
                var LastTerm = _context.Terms.Last();
                if (academicSection.FirstTerm.StartDate <= LastTerm.EndDate)
                {
                    return BadRequest("First term's start date must be after the ending date of the previous term");
                }
            }
            
            if (academicSection.SecondTerm.StartDate <= academicSection.FirstTerm.EndDate)
            {
                return BadRequest("Second term's starting date must be after the first term's ending date");
            }
            if (academicSection.ThirdTerm.StartDate <= academicSection.SecondTerm.EndDate)
            {
                return BadRequest("Third term's starting date must be after the second term's ending date");
            }
            _context.Terms.Add(academicSection.FirstTerm);
            _context.Terms.Add(academicSection.SecondTerm);
            _context.Terms.Add(academicSection.ThirdTerm);

            _context.AcademicSections.Add(academicSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcademicSection", new { id = academicSection.Id }, academicSection);
        }
    }
}
