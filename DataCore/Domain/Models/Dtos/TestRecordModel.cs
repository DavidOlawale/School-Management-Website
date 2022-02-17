using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCore.Models.Dtos
{
    public class TestRecordModel
    {
        public IEnumerable<TestDto> Tests;
        public string DepartmentName;
    }
}
