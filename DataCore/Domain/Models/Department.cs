using System;

namespace DataCore.Models
{
    public class Department
    {
        public Department(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? DepartmentHeadId { get; set; }
        public Teacher DepartmentHead { get; set; }

    }

}
