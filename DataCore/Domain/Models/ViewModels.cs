using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataCore.Models
{
    public class CreateUserViewModel
    {
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Parent Parent { get; set; }

        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage ="Minimum length of 6"), MaxLength(15, ErrorMessage ="max length of 15")]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        public string ReTypePassword { get; set; }
    }
}
