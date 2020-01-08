using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
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