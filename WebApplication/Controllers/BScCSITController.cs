using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patancampus.Controllers
{
    public class BScCSITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admission()
        {
            return View();
        }
        public IActionResult CourseDetails()
        {
            return View();
        }
    }
}
