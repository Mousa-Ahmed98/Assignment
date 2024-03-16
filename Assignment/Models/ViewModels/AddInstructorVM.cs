namespace Assignment.Models.ViewModels
{
    public class AddInstructorVM
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; }
        public List<Department> Departments { get; set; }

        public int CourseId { get; set; }
        public List<Course> Courses { get; set; }

        public static AddInstructorVM InstantiateInsVM(Instructor instructor)
        {
            AddInstructorVM addInstructorVM = new AddInstructorVM();
            addInstructorVM.Name = instructor.Name;
            addInstructorVM.Image = instructor.Image;
            addInstructorVM.Salary = instructor.Salary;
            addInstructorVM.Address = instructor.Address;
            return addInstructorVM;
        }
    }
}
