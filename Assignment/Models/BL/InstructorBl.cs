using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class InstructorBl
    {
        static ITIContext ITIContext = new ITIContext();
        public static List<Instructor> GetAll()
        {
            return ITIContext
                .Instructors
                .Include(I => I.Course)
                .Include(I => I.Department)
                .ToList();
        }

        public static Instructor? Get(int Id)
        {
            return ITIContext
                .Instructors
                .Where(I => I.Id == Id)
                .Include(I => I.Course)
                .Include(I => I.Department).FirstOrDefault();
        }

        public static async Task Add(Instructor instructor)
        {
            ITIContext.Instructors.Add(instructor);
            try
            {
                await ITIContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
