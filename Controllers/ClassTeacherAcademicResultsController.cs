using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    [Authorize(Roles = RoleNames.Teacher)]
    public class ClassTeacherAcademicResultsController : Controller
    {
        public IActionResult Exam()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}