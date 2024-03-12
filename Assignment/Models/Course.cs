using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    [Table("Course")]
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<CrsResult> crsResults { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
