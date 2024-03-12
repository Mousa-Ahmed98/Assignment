using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        InstructorBl InstructorBl = new InstructorBl();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View("GetAll", InstructorBl.GetAll());
        }


        public IActionResult Get(int Id)
        {
            return View("GetView", InstructorBl.Get(Id));
        }
    }
}
