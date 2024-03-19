using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.Services;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepository instructor;

        public InstructorController(IInstructorRepository instructor)
        {
            this.instructor = instructor;
        }
        
        public IActionResult Index()
        {
            List<Instructor> instructors = instructor.GetAll();
            return View();
        }

        public IActionResult GetAll()
        {
            return View("GetAll", instructor.GetAll());
        }


        public IActionResult Get(int Id)
        {
            return View("GetView", instructor.Get(Id));
        }

        public IActionResult Add()
        {
            AddInstructorVM addInstructorVM = new AddInstructorVM();
            addInstructorVM.Courses = CourseBl.GetAll();
            addInstructorVM.Departments = DepartmentBl.GetAll();


            return View("Add", addInstructorVM);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAdd(Instructor _instructor)
        {
            try
            {
                await instructor.Add(_instructor);
                return Content("Added successfully");
            }
            catch(Exception e)
            {
                AddInstructorVM addInstructorVM = AddInstructorVM.InstantiateInsVM(_instructor);
                
                return View("Add", addInstructorVM);
            }
        }
    }
}
