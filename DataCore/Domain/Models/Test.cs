using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Test
    {
        public Guid StudentId { get; set; }
        public int DepartmentSubjectDepartmentId { get; set; }
        public int DepartmentSubjectSubjectId { get; set; }
        public DepartmentSubject DepartmentSubject { get; set; }
        public int TermId { get; set; }
        public Term Term { get; set; }

        [Range(0, 40), Required]
        public int Score { get; set; }
    }

}
