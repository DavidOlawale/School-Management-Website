using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Dtos
{
    public class TestRecordModel
    {
        public IEnumerable<TestDto> Tests;
        public string DepartmentName;
    }
}
