using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.Services;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepository instructorRepository;
        private readonly IDepartmentRepository departmentRepository;

        public InstructorController(IInstructorRepository instructor,
            IDepartmentRepository departmentRepository)
        {
            instructorRepository = instructor;
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            List<Instructor> instructors = instructorRepository.GetAll();
            return View("Index");
        }

        public IActionResult GetAll()
        {
            return View("GetAll", instructorRepository.GetAll());
        }


        public IActionResult Get(int Id)
        {
            return View("GetView", instructorRepository.Get(Id));
        }

        public IActionResult Add()
        {
            AddInstructorVM addInstructorVM = new AddInstructorVM();
            addInstructorVM.Courses = CourseBl.GetAll();
            addInstructorVM.Departments = departmentRepository.GetAll();


            return View("Add", addInstructorVM);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAdd(Instructor _instructor)
        {
            try
            {
                await instructorRepository.Add(_instructor);
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
