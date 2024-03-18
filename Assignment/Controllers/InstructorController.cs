using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Assignment.Controllers
{
    public class InstructorController : Controller
    {
        
        public IActionResult Index()
        {
            List<Instructor> instructors = InstructorBl.GetAll();
            return View("GetAll", InstructorBl.GetAll());
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
            addInstructorVM.Departments = DepartmentBl.GetAll();
            addInstructorVM.Courses = CourseBl.GetAllWhere(addInstructorVM.Departments.FirstOrDefault().Id);


            return View("Add", addInstructorVM);
        }
        public IActionResult GetCoursesOfDepartment(int DID)
        {
            return Json(CourseBl.GetAllWhere(DID));
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
                addInstructorVM.Departments = DepartmentBl.GetAll();
                addInstructorVM.Courses = CourseBl.GetAllWhere(addInstructorVM.Departments.FirstOrDefault().Id);

                return View("Add", addInstructorVM);
            }
        }

        public IActionResult Search(string Key)
        {
            List<SearchInstructorViewModel> searchInstructorViewModels = new List<SearchInstructorViewModel>();
            foreach (Instructor item in InstructorBl.Search(Key))
            {
                searchInstructorViewModels.Add(new SearchInstructorViewModel()
                {
                    Name = item.Name,
                    Address = item.Address,
                    Image = item.Image,
                    Salary = item.Salary,
                    Department = item.Department.Name,
                    Course = item.Course.Name
                });
            }
            return Json(searchInstructorViewModels);
        }
    }
}
