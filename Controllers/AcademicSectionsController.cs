using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    public class AcademicSectionsController : Controller
    {
        public IActionResult AddAcademicSection()
        {
            return View();
        }
    }
}