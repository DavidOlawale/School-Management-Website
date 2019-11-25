using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Dtos
{
    public class ExamDto
    {
        public Guid StudentId { get; set; }
        public int DepartmentSubjectSubjecttId { get; set; }
        [Range(0, 60), Required]
        public int Score { get; set; }
    }
}
