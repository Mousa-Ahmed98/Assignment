using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class InstructorBl
    {
        private ITIContext ITIContext = new ITIContext();
        public List<Instructor> GetAll()
        {
            return ITIContext
                .Instructors
                .Include(I => I.Course)
                .Include(I => I.Department)
                .ToList();
        }

        public Instructor Get(int Id)
        {
            return ITIContext
                .Instructors
                .Where(I => I.Id == Id)
                .Include(I => I.Course)
                .Include(I => I.Department).FirstOrDefault();
        }
    }
}
