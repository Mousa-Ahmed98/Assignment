namespace Assignment.Models.ViewModels
{
    public class AddCourseVM
    {
        public string Name { get; set; }

        public int MinDegree { get; set; }
        public int Hours { get; set; }

        public int DepartmentId { get; set; }
        public List<Department> Departments { get; set; }

        public bool IsError = false;


        public static AddCourseVM InstantiateInsVM(Course course)
        {
            AddCourseVM addCourseVM = new AddCourseVM();
            addCourseVM.Name = course.Name;
            addCourseVM.Hours = course.Hours;
            addCourseVM.MinDegree = course.MinDegree;
            return addCourseVM;
        }
    }
}
