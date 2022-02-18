using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Exam
    {
        public Guid StudentId { get; set; }
        public int DepartmentSubjectDepartmentId { get; set; }
        public int DepartmentSubjectSubjectId { get; set; }
        public DepartmentSubject DepartmentSubject{ get; set; }
        public int TermId { get; set; }
        public Term Term { get; set; }

        [Range(0, 60), Required]
        public int Score { get; set; }
    }

}
