using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using School.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public static class RoleNames
    {
        public  const string Admin = "Admin";
        public const string Student = "Student";
        public const string Teacher = "Teacher";
        public const string Parent = "Parent";

    }

    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get => FirstName + " " + MiddleName + " " + LastName ?? "";}

        [Required]
        public string Address { get; set; }
        public bool HasProfilePhoto { get; set; }

        [Display(Name ="Profile Photo")]
        public string ProfilePhotoExtension { get; set; }
    }
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() : base()
        {

        }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }

    }

    public class Student : ApplicationUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }

        public IEnumerable<Attendance> Atendances { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
    public class Teacher : ApplicationUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public Department DepartmentHeading { get; set; }

    }
    public class Admin : ApplicationUser
    {

    }
    public class Class
    {
        public Class(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
    public class Parent : ApplicationUser
    {
        public IEnumerable<Student> Children { get; set; }

    }
    public class Notification
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }
    public class Attendance
    {
        private readonly ApplicationDbContext _context;
        public int Id { get; set; }

        public Guid StudentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now.Date;

        [Required]
        public bool Present { get; set; }

    }
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
    public class Subject
    {
        public Subject(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
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
    public class Exam
    {
        public Guid StudentId { get; set; }
        public int DepartmentSubjectDepartmentId { get; set; }
        public int DepartmentSubjectSubjectId { get; set; }
        public DepartmentSubject DepartmentSubject{ get; set; }
        public int TermId { get; set; }
        public Term Term { get; set; }

        [Range(0, 60), Required]
        public int Score { get; set; }
    }
    public class Test
    {
        public Guid StudentId { get; set; }
        public int DepartmentSubjectDepartmentId { get; set; }
        public int DepartmentSubjectSubjectId { get; set; }
        public DepartmentSubject DepartmentSubject { get; set; }
        public int TermId { get; set; }
        public Term Term { get; set; }

        [Range(0, 40), Required]
        public int Score { get; set; }
    }
    public class Term
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }

    public class AcademicSection
    {
        public int Id { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public int? FirstTermId { get; set; }
        public Term FirstTerm { get; set; }

        public int? SecondTermId { get; set; }
        public Term SecondTerm { get; set; }

        public int? ThirdTermId { get; set; }
        public Term ThirdTerm { get; set; }
    }
    public class Message
    {
        public int Id { get; set; }
        public Guid SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
        public Guid? ReceiverId { get; set; }
        public string Content { get; set; }
        public bool Received { get; set; }
        public bool ToAllParents { get; set; }
        public bool ToAdmin { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
    }

}
