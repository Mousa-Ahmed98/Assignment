using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        
        public IActionResult Index()
        {
            List<Instructor> instructors = InstructorBl.GetAll();
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

        public IActionResult Add()
        {
            AddInstructorVM addInstructorVM = new AddInstructorVM();
            addInstructorVM.Courses = CourseBl.GetAll();
            addInstructorVM.Departments = DepartmentBl.GetAll();


            return View("Add", addInstructorVM);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAdd(Instructor instructor)
        {
            try
            {
                await InstructorBl.Add(instructor);
                return Content("Added successfully");
            }
            catch(Exception e)
            {
                AddInstructorVM addInstructorVM = AddInstructorVM.InstantiateInsVM(instructor);
                
                return View("Add", addInstructorVM);
            }
        }
    }
}
