using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.Services;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        /*private readonly IInstructorRepository instructorRepository;
        private readonly IDepartmentRepository departmentRepository;*/

        private UnitOfWork unitOfWork = new UnitOfWork();

        /*public InstructorController(IInstructorRepository instructor,
            IDepartmentRepository departmentRepository)
        {
            instructorRepository = instructor;
            this.departmentRepository = departmentRepository;
        }*/

        /*public InstructorController(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }*/

        public IActionResult Index()
        {
            IEnumerable<Instructor> instructors = unitOfWork.InstructorRepository.Get();//instructorRepository.GetAll();
            return View("Index");
        }

        public IActionResult GetAll()
        {
            return View("GetAll", unitOfWork.InstructorRepository.Get());//instructorRepository.GetAll());
        }


        public IActionResult Get(int Id)
        {
            return View("GetView", unitOfWork.InstructorRepository.GetById(Id));//instructorRepository.Get(Id));
        }

        public IActionResult Add()
        {
            AddInstructorVM addInstructorVM = new AddInstructorVM
            {
                Courses = (List<Course>)unitOfWork.CourseRepository.Get(),//CourseBl.GetAll();
                Departments = (List<Department>)unitOfWork.DepartmentRepository.Get()
            };


            return View("Add", addInstructorVM);
        }
        [HttpPost]
        public IActionResult SaveAdd(Instructor _instructor)
        {
            try
            {
                unitOfWork.InstructorRepository.Insert(_instructor);
                unitOfWork.Save();
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
