using DataCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCore.Models.ViewModels
{
    public class ClassDetailsViewModel
    {
        public ClassDetailsViewModel(Class Class, Teacher teacher)
        {
            this.Class = Class;
            this.Teacher = teacher;
        }
        public Teacher Teacher { get; set; }
        public Class Class;
        public int NumberOfStudents { get { return Students.Count(); } }
        public IEnumerable<Student> Students;

        public IEnumerable<Student> StudentsWithoutAttendance;
        public double AverageAge { get {
                int TotalAge = 0;
                foreach (var student in Students)
                {
                    int Age = DateTime.Now.Year - student.DOB.Year;
                    TotalAge+= Age;
                }
                if (NumberOfStudents == 0)
                {
                    return 0;
                }
                return TotalAge/NumberOfStudents;
            }
        }

    }
}
