using Assignment.Models.CustomAttributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models.ViewModels
{
    public class AddCourseVM
    {
        [MaxLength(25, ErrorMessage = "Name must be less than 25 letter")]
        [MinLength(3, ErrorMessage = "Name must be greater than 3 letter")]
        [Unique]
        public string Name { get; set; }
        [Range(50, 100)]
        public int Degree { get; set; }
        [Remote("CheckMinDegree", "Course", ErrorMessage = "Invalid hours", AdditionalFields = "Degree")]
        public int MinDegree { get; set; }
        [DividedByThree]
        public int Hours { get; set; }

        public int DepartmentId { get; set; }
        public List<Department>? Departments { get; set; }

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
