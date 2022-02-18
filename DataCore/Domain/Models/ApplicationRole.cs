using Microsoft.AspNetCore.Identity;
using System;

namespace DataCore.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() : base()
        {

        }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }

    }

}
