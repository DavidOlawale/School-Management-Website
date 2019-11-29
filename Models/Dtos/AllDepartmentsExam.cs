using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Dtos
{
    public class AllDepartmentsExams
    {
        public List<StudentExams> ScienceExams;
        public List<StudentExams> CommercialExams;
        public List<StudentExams> ArtExams;
    }
}
