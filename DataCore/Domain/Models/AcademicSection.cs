using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class AcademicSection
    {
        public int Id { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public int? FirstTermId { get; set; }
        public Term FirstTerm { get; set; }

        public int? SecondTermId { get; set; }
        public Term SecondTerm { get; set; }

        public int? ThirdTermId { get; set; }
        public Term ThirdTerm { get; set; }
    }

}
