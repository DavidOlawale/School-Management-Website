using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCore.Models.Dtos
{
    public class ExamRecordModel
    {
        public IEnumerable<ExamDto> Exams;
        public string DepartmentName;
    }
}
