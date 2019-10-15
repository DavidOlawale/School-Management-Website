using School.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models.ViewModels
{
    public class ClassDetailsViewModel
    {
        public ClassDetailsViewModel(Class Class)
        {
            this.Class = Class;

        }
        public Class Class { get; set; }
        public int NumberOfStudents { get { return Students.Count(); } }
        public IEnumerable<Student> Students { get; set; }
        public double AverageAge { get {
                int TotalAge = 0;
                foreach (var student in Students)
                {
                    int Age = DateTime.Now.Year - student.DOB.Year;
                    TotalAge+= Age;
                }
                return TotalAge/NumberOfStudents;
            }
        }

    }
}
