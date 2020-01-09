using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    [Authorize(Roles =RoleNames.Admin)]
    public class AcademicSectionsController : Controller
    {
        public IActionResult AddAcademicSection()
        {
            return View();
        }
    }
}