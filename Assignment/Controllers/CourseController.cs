using Assignment.Models;
using Assignment.Models.BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class CourseController : Controller
    {
        ITIContext ITIContext = new ITIContext();

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CourseResult(int CID)
        {
            Course Course = CourseBl.GetCourseResult(CID);


            return View("CourseResult", Course);
        }
    }
}
