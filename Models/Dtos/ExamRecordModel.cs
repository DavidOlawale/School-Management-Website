﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.Dtos
{
    public class ExamRecordModel
    {
        public IEnumerable<ExamDto> Exams;
        public string DepartmentName;
    }
}