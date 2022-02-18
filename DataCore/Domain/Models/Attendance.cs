using DataCore.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Attendance
    {
        private readonly ApplicationDbContext _context;
        public int Id { get; set; }

        public Guid StudentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now.Date;

        [Required]
        public bool Present { get; set; }

    }

}
