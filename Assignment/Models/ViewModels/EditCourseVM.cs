using Assignment.Models.BL.CustomAttributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models.ViewModels
{
    public class EditCourseVM
    {

        public int Id { get; set; }
        [MaxLength(25)]
        [MinLength(3)]
        [Unique]
        public string Name { get; set; }
        [Range(50, 100)]
        public int Degree { get; set; }
        [Remote("CheckMinDegree", "Course", ErrorMessage = "Invalid hours", AdditionalFields = "Degree")]
        public int MinDegree { get; set; }
        [DividedByThree]
        public int Hours { get; set; }

        public int DepartmentId { get; set; }
    }
}
