using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.Services;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class CourseController : Controller
    {
        /*private readonly IDepartmentRepository departmentRepository;

        public CourseController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }*/

        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CourseResult(int CID)
        {
            Course? Course = unitOfWork.CourseRepository.GetById(CID);//CourseBl.GetCourseResult(CID);


            return View("CourseResult", Course);
        }

        public IActionResult Add()
        {
            AddCourseVM addCourseVM = new AddCourseVM();
            addCourseVM.Departments = (List<Department>) unitOfWork.DepartmentRepository.Get();//departmentRepository.GetAll();
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
            addCourseVM.Departments = (List<Department>)unitOfWork.DepartmentRepository.Get();//departmentRepository.GetAll();
            addCourseVM.IsError = true;
            return View("Add", addCourseVM);
        }

        public IActionResult GetAll()
        {
            List<Course> courses = (List<Course>)unitOfWork.CourseRepository.Get();//CourseBl.GetAll();
            return View("GetAll", courses);
        }


        public IActionResult Edit(int Id)
        {
            Course? course = unitOfWork.CourseRepository.GetById(Id);//CourseBl.GetCourse(Id);
            EditCourseVM editCourseVM = new EditCourseVM();
            if(course != null)
            {
                editCourseVM.Id = course.Id;
                editCourseVM.Name = course.Name;
                editCourseVM.Degree = course.Degree;
                editCourseVM.MinDegree = course.MinDegree;
                editCourseVM.Hours = course.Hours;
                editCourseVM.DepartmentId = course.DepartmentId;
            }
            return View("Edit", editCourseVM);
        }
        public IActionResult CheckMinDegree(int MinDegree, int Degree)
        {
            return Json(MinDegree <= Degree);
        }
    }
}
