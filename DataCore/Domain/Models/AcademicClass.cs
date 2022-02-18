using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class AcademicClass
    {
        public AcademicClass(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }

}
