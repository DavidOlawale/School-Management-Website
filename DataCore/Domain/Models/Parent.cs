using System.Collections.Generic;

namespace DataCore.Models
{
    public class Parent : ApplicationUser
    {
        public IEnumerable<Student> Children { get; set; }

    }

}
