using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class CourseController : Controller
    {
        

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
        public async Task<IActionResult> SaveAdd(AddCourseVM courseVm)
        {
            Course course2 = new Course()
            {
                Name = courseVm.Name,
                Degree = courseVm.Degree,
                MinDegree = courseVm.MinDegree,
                Hours = courseVm.Hours,
                DepartmentId = courseVm.DepartmentId
            };

            if (ModelState.IsValid)
            {
                if (await CourseBl.Add(course2) == 1)
                {
                    return RedirectToAction("GetAll");
                }
            }

            AddCourseVM addCourseVM = AddCourseVM.InstantiateInsVM(course2);
            /*if (CourseBl.IsValidToAdd(addCourseVM))
            {
                if (await CourseBl.Add(course) == 1)
                {
                    return RedirectToAction("GetAll");
                }
            }*/
            addCourseVM.Departments = DepartmentBl.GetAll();
            //addCourseVM.IsError = true;
            return View("Add", addCourseVM);
        }

        public IActionResult GetAll()
        {
            List<Course> courses = CourseBl.GetAll();
            return View("GetAll", courses);
        }

        public IActionResult CheckMinDegree(int MinDegree, int Degree)
        {
            return Json(MinDegree <= Degree);
        }
    }
}
