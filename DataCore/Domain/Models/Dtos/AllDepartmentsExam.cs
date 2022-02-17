using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCore.Models.Dtos
{
    public class AllDepartmentsExams
    {
        public List<StudentExams> ScienceExams;
        public List<StudentExams> CommercialExams;
        public List<StudentExams> ArtExams;
    }
}
