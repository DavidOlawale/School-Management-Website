using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{

    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get => FirstName + " " + MiddleName + " " + LastName;}

        [Required]
        public string Address { get; set; }

        [Display(Name ="Profile Photo")]
        public byte[] ProfileImage { get; set; }
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

    }
    public class Teacher : ApplicationUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
    public class Admin : ApplicationUser
    {

    }
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
    public class Parent : ApplicationUser
    {
        public IEnumerable<Student> Children { get; set; }

    }
    public static class RoleNames
    {
        public static string Admin => "Admin";
        public static string Student => "Student";
        public static string Teacher => "Teacher";

    }

    public class Notification
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }
}
