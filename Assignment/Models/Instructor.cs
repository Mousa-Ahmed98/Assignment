using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
