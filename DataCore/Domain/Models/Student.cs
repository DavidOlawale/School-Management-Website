using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Student : ApplicationUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int ClassId { get; set; }
        public AcademicClass Class { get; set; }

        public IEnumerable<Attendance> Atendances { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }

}
