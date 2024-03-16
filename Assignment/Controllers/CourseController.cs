using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.ViewModels;
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

        public IActionResult Add()
        {
            AddCourseVM addCourseVM = new AddCourseVM();
            addCourseVM.Departments = DepartmentBl.GetAll();
            return View("Add",addCourseVM);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAdd(Course course)
        {
            AddCourseVM addCourseVM = AddCourseVM.InstantiateInsVM(course);
            if (CourseBl.IsValidToAdd(addCourseVM))
            {
                if (await CourseBl.Add(course) == 1)
                {
                    return RedirectToAction("GetAll");
                }
            }
            addCourseVM.Departments = DepartmentBl.GetAll();
            addCourseVM.IsError = true;
            return View("Add", addCourseVM);
        }

        public IActionResult GetAll()
        {
            List<Course> courses = CourseBl.GetAll();
            return View("GetAll", courses);
        }
    }
}
