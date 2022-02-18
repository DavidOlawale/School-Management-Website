using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
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

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }

}
