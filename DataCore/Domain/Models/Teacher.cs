using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Teacher : ApplicationUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        public int ClassId { get; set; }
        public AcademicClass Class { get; set; }

        public Department DepartmentHeading { get; set; }

    }

}
