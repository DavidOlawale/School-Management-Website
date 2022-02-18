namespace DataCore.Models
{
    public class DepartmentSubject
    {
        public DepartmentSubject(int departmentId, int subjectId)
        {
            DepartmentId = departmentId;
            SubjectId = subjectId;
        }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }

}
